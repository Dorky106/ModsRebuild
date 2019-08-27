using PhentrixGames.NewColonyAPI.Configuration;
using Pipliz;
using Pipliz.JSON;
using System;
using System.Collections.Generic;
using System.IO;

namespace PhentrixGames.NewColonyAPI.Power
{
    [ModLoader.ModManager]
    public static class PowerManager
    {
        [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
        public class NCAPIPowerType : Attribute { }

        [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
        public class NCAPIPowerRecipe : Attribute { }

        #region Config Settings

        private static long nextFeedTime = 0;
        private static long betweenFeeds = 0;
        private static ushort powerLose = 0;

        #endregion Config Settings

        private static bool Enabled = false;
        private static Dictionary<string, PowerObject> validblockIDs = new Dictionary<string, PowerObject>();
        private static Dictionary<Vector3Int, Machine> machines = new Dictionary<Vector3Int, Machine>();
        private static Dictionary<Vector3Int, Generator> generators = new Dictionary<Vector3Int, Generator>();
        private static Dictionary<Vector3Int, Battery> batteries = new Dictionary<Vector3Int, Battery>();

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterSelectedWorld, NewColonyAPIEntry.Naming + "PowerSysyem")]
        [ModLoader.ModCallbackDependsOn(NewColonyAPIEntry.Naming + "LoadConfigs")]
        internal static void Initialize()
        {
            Enabled = ConfigManager.GetConfigBooleanOrDefault(NewColonyAPIEntry.ModName, "powersystem.enabled", false);
            if (Enabled)
            {
                betweenFeeds = ConfigManager.GetConfigIntOrDefault(NewColonyAPIEntry.ModName, "powersystem.update", 60);
                if (betweenFeeds < 15)
                    betweenFeeds = 15;

                powerLose = (ushort)ConfigManager.GetConfigIntOrDefault(NewColonyAPIEntry.ModName, "powersystem.powerlose", 2);
                if (powerLose < 2)
                {
                    powerLose = 2;
                }

                nextFeedTime = NextUpdate();
                LoadBatteriesData();
                LoadMachinesData();
                LoadGeneratorsData();
            }
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnChangedBlock, NewColonyAPIEntry.Naming + "AddRemovePowerObject")]
        internal static void AddRemovePowerObject(ModLoader.OnTryChangeBlockData blockData)
        {
            if (Enabled)
            {
                if (blockData.RequestOrigin.Type == BlockChangeRequestOrigin.EType.Player)
                {
                    switch (PowerType(blockData.TypeNew.Name))
                    {
                        case "Generator":
                            if (PowerManager.GetPowerObject(blockData.TypeNew.Name, out PowerObject generator))
                            {
                                Generator gen = (Generator)generator as Generator;
                                MarkObject(EPowerType.Generator, blockData.Position, gen);
                            }
                            break;

                        case "Machine":
                            if (PowerManager.GetPowerObject(blockData.TypeNew.Name, out PowerObject machine))
                            {
                                Machine mac = (Machine)machine as Machine;
                                MarkObject(EPowerType.Machine, blockData.Position, mac);
                            }
                            break;

                        case "Battery":
                            if (PowerManager.GetPowerObject(blockData.TypeNew.Name, out PowerObject battery))
                            {
                                Battery bat = (Battery)battery as Battery;
                                MarkObject(EPowerType.Battery, blockData.Position, bat);
                            }
                            break;
                    }

                    if (validblockIDs.ContainsKey(blockData.TypeOld.Name))
                    {
                        PowerManager.UnMarkObject(blockData.Position);
                    }
                }
            }
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnAutoSaveWorld, NewColonyAPIEntry.Naming + "PowerSave")]
        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnQuit, NewColonyAPIEntry.Naming + "PowerSave")]
        internal static void SaveData()
        {
            if (Enabled)
            {
                SaveBatteriesData();
                SaveGeneratorsData();
                SaveMachinesData();
            }
        }

        private static void SaveGeneratorsData()
        {
            try
            {
                string jSONPath = GetJSONPath("generatordata");
                if (generators.Count == 0)
                {
                    File.Delete(jSONPath);
                }
                else
                {
                    JSONNode rootnode = new JSONNode(NodeType.Array);
                    foreach (Vector3Int pos in generators.Keys)
                    {
                        Generator generator = generators[pos];
                        JSONNode child = new JSONNode(NodeType.Object);
                        child.SetAs("pos", Helpers.Utilities.Vector3IntToNode(pos));
                        child.SetAs("name", generator.Name);
                        child.SetAs("power", generator.GetPower());
                        child.SetAs("maxpower", generator.GetMaxPower());
                        child.SetAs("generates", generator.Generates);
                        rootnode.AddToArray(child);
                    }
                    JSON.Serialize(jSONPath, rootnode);
                }
            }
            catch (Exception exception)
            {
                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Exception in saving all Generator Data:" + exception.Message, Helpers.Logging.LogType.Issue);
            }
        }

        private static void SaveMachinesData()
        {
            try
            {
                string jSONPath = GetJSONPath("machinedata");
                if (machines.Count == 0)
                {
                    File.Delete(jSONPath);
                }
                else
                {
                    JSONNode rootnode = new JSONNode(NodeType.Array);
                    foreach (Vector3Int pos in machines.Keys)
                    {
                        Machine machine = machines[pos];
                        JSONNode child = new JSONNode(NodeType.Object);
                        child.SetAs("pos", Helpers.Utilities.Vector3IntToNode(pos));
                        child.SetAs("name", machine.Name);
                        child.SetAs("power", machine.GetPower());
                        child.SetAs("maxpower", machine.GetMaxPower());
                        child.SetAs("powerusage", machine.PowerUsage);
                        rootnode.AddToArray(child);
                    }
                    JSON.Serialize(jSONPath, rootnode);
                }
            }
            catch (Exception exception)
            {
                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Exception in saving all Machine Data:" + exception.Message, Helpers.Logging.LogType.Issue);
            }
        }

        private static void SaveBatteriesData()
        {
            try
            {
                string jSONPath = GetJSONPath("batterydata");
                if (batteries.Count == 0)
                {
                    File.Delete(jSONPath);
                }
                else
                {
                    JSONNode rootnode = new JSONNode(NodeType.Array);
                    foreach (Vector3Int pos in batteries.Keys)
                    {
                        Battery battery = batteries[pos];
                        JSONNode child = new JSONNode(NodeType.Object);
                        child.SetAs("pos", Helpers.Utilities.Vector3IntToNode(pos));
                        child.SetAs("name", battery.Name);
                        child.SetAs("power", battery.GetPower());
                        child.SetAs("maxpower", battery.GetMaxPower());
                        rootnode.AddToArray(child);
                    }
                    JSON.Serialize(jSONPath, rootnode);
                }
            }
            catch (Exception exception)
            {
                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Exception in saving all Battery Data:" + exception.Message, Helpers.Logging.LogType.Issue);
            }
        }

        public static bool GetPowerObject(string id, out PowerObject powerObject)
        {
            powerObject = null;
            if (IsPowerBlock(id))
            {
                if (validblockIDs[id].GetType().BaseType == typeof(Generator))
                {
                    Generator tmp = (Generator)validblockIDs[id] as Generator;
                    powerObject = new Generator(tmp.Name, tmp.GetMaxPower(), tmp.Generates);
                }
                if (validblockIDs[id].GetType().BaseType == typeof(Machine))
                {
                    Machine tmp = (Machine)validblockIDs[id] as Machine;
                    powerObject = new Machine(tmp.Name, tmp.GetMaxPower(), tmp.PowerUsage);
                }
                if (validblockIDs[id].GetType().BaseType == typeof(Battery))
                {
                    Battery tmp = (Battery)validblockIDs[id] as Battery;
                    powerObject = new Battery(tmp.Name, tmp.GetMaxPower());
                }
                return true;
            }
            return false;
        }

        public static void GeneratePower(Vector3Int pos)
        {
            if (generators.ContainsKey(pos))
            {
                generators[pos].Generate();
            }
        }

        public static bool Operate(Vector3Int vector3Int)
        {
            if (machines.ContainsKey(vector3Int))
            {
                return machines[vector3Int].Operate();
            }
            return false;
        }

        public static bool GetPower(Vector3Int pos, out int power)
        {
            power = 0;
            if (machines.ContainsKey(pos))
            {
                power = machines[pos].GetPower();
                return true;
            }
            if (generators.ContainsKey(pos))
            {
                power = generators[pos].GetPower();
                return true;
            }
            if (batteries.ContainsKey(pos))
            {
                power = batteries[pos].GetPower();
                return true;
            }
            return false;
        }

        public static void ValidateBlockID(string id, PowerObject powerObject)
        {
            if (validblockIDs.ContainsKey(id) == false)
            {
                validblockIDs.Add(id, powerObject);
            }
        }

        public static bool GetMaxPower(Vector3Int pos, out int maxpower)
        {
            maxpower = 0;
            if (machines.ContainsKey(pos))
            {
                maxpower = machines[pos].GetMaxPower();
                return true;
            }
            if (generators.ContainsKey(pos))
            {
                maxpower = generators[pos].GetMaxPower();
                return true;
            }
            if (batteries.ContainsKey(pos))
            {
                maxpower = batteries[pos].GetMaxPower();
                return true;
            }
            return false;
        }

        public static bool IsPowerBlock(string id)
        {
            if (validblockIDs.ContainsKey(id))
            {
                return true;
            }
            return false;
        }

        public static string PowerType(string id)
        {
            if (IsPowerBlock(id))
            {
                if (validblockIDs[id].GetType().BaseType == typeof(Generator))
                    return "Generator";
                if (validblockIDs[id].GetType().BaseType == typeof(Machine))
                    return "Machine";
                if (validblockIDs[id].GetType().BaseType == typeof(Battery))
                    return "Battery";
            }
            return "";
        }

        public static void MarkObject(EPowerType powerType, Vector3Int pos, PowerObject powerObject)
        {
            switch (powerType)
            {
                case EPowerType.Battery:
                    if (batteries.ContainsKey(pos) == false)
                    {
                        batteries.Add(pos, powerObject as Battery);
                    }
                    break;

                case EPowerType.Generator:
                    if (generators.ContainsKey(pos) == false)
                    {
                        generators.Add(pos, powerObject as Generator);
                    }
                    break;

                case EPowerType.Machine:
                    if (machines.ContainsKey(pos) == false)
                    {
                        machines.Add(pos, powerObject as Machine);
                    }
                    break;
            }
        }

        public static void UnMarkObject(Vector3Int pos)
        {
            if (batteries.ContainsKey(pos))
            {
                batteries[pos] = null;
                batteries.Remove(pos);
                return;
            }
            if (generators.ContainsKey(pos))
            {
                generators[pos] = null;
                generators.Remove(pos);
                return;
            }
            if (machines.ContainsKey(pos))
            {
                machines[pos] = null;
                machines.Remove(pos);
                return;
            }
        }

        private static void LoadBatteriesData()
        {
            try
            {
                if (JSON.Deserialize(GetJSONPath("batterydata"), out JSONNode array, false))
                {
                    if (array != null)
                    {
                        foreach (var node in array.LoopArray())
                        {
                            try
                            {
                                string name = node["name"].GetAs<string>();
                                MarkObject(EPowerType.Battery,
                                    Helpers.Utilities.NodeToVector3Int(node["pos"].GetAs<JSONNode>()),
                                    new Battery(
                                        node["name"].GetAs<string>(),
                                        node["power"].GetAs<ushort>(),
                                        node["maxpower"].GetAs<ushort>()));
                            }
                            catch (Exception e)
                            {
                                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Expection while Battery Data: " + e.Message + "\n" + e.StackTrace, Helpers.Logging.LogType.Issue);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Exception while Loading Battery Data File: " + e.Message + "\n" + e.StackTrace, Helpers.Logging.LogType.Error);
            }
        }

        private static void LoadMachinesData()
        {
            try
            {
                if (JSON.Deserialize(GetJSONPath("machinedata"), out JSONNode array, false))
                {
                    if (array != null)
                    {
                        foreach (JSONNode node in array.LoopArray())
                        {
                            try
                            {
                                string name = node["name"].GetAs<string>();
                                MarkObject(
                                    EPowerType.Machine,
                                    Helpers.Utilities.NodeToVector3Int(node["pos"].GetAs<JSONNode>()),
                                    new Machine(
                                        node["name"].GetAs<string>(),
                                        node["power"].GetAs<ushort>(),
                                        node["maxpower"].GetAs<ushort>(),
                                        node["powerusage"].GetAs<ushort>()));
                            }
                            catch (Exception exception)
                            {
                                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Exception while Machine Data:" + exception.Message, Helpers.Logging.LogType.Issue);
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Exception in loading all Machine Data File:" + exception.Message, Helpers.Logging.LogType.Error);
            }
        }

        private static void LoadGeneratorsData()
        {
            try
            {
                if (JSON.Deserialize(GetJSONPath("generatordata"), out JSONNode array, false))
                {
                    if (array != null)
                    {
                        foreach (JSONNode node in array.LoopArray())
                        {
                            try
                            {
                                string name = node["name"].GetAs<string>();
                                MarkObject(
                                    EPowerType.Generator,
                                    Helpers.Utilities.NodeToVector3Int(node["pos"].GetAs<JSONNode>()),
                                    new Generator(
                                        node["name"].GetAs<string>(),
                                        node["power"].GetAs<ushort>(),
                                        node["maxpower"].GetAs<ushort>(),
                                        node["generates"].GetAs<ushort>()));
                            }
                            catch (Exception exception)
                            {
                                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Exception while Generator Data:" + exception.Message, Helpers.Logging.LogType.Issue);
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Exception in loading all Generator Data File:" + exception.Message, Helpers.Logging.LogType.Error);
            }
        }

        private static long NextUpdate()
        {
            return (long)(betweenFeeds * 1000 + Time.MillisecondsSinceStart);
        }

        private static string GetJSONPath(string filename)
        {
            return "gamedata/savegames/" + ServerManager.WorldName + "/" + filename + ".json";
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnFixedUpdate, NewColonyAPIEntry.Naming + "TransferPower")]
        internal static void FeedMachines()
        {
            if (Enabled)
            {
                if (Time.MillisecondsSinceStart > nextFeedTime)
                {
                    nextFeedTime = NextUpdate();

                    foreach (Vector3Int pos in batteries.Keys)
                    {
                        batteries[pos].PowerLose(powerLose);
                        List<Vector3Int> tocheck = new List<Vector3Int>()
                        {
                            pos
                        };
                        for (int i = 0; i < tocheck.Count; i++)
                        {
#pragma warning disable IDE0018 // Inline variable declaration
                            ushort blockID = 0;
#pragma warning restore IDE0018 // Inline variable declaration
                            if (World.TryGetTypeAt(tocheck[i] + Vector3Int.back, out blockID))
                            {
                                if (validblockIDs.ContainsKey(ItemTypes.IndexLookup.GetName(blockID)))
                                {
                                    if (generators.ContainsKey(tocheck[i] + Vector3Int.back))
                                    {
                                        batteries[pos].RecievePower(generators[tocheck[i] + Vector3Int.back].HasPower(batteries[pos].PowerNeeded()));
                                        if (batteries[pos].PowerNeeded() == 0)
                                            break;
                                    }
                                    if (tocheck.Contains(tocheck[i] + Vector3Int.back) == false)
                                    {
                                        tocheck.Add(tocheck[i] + Vector3Int.back);
                                    }
                                }
                            }
                            if (World.TryGetTypeAt(tocheck[i] + Vector3Int.forward, out blockID))
                            {
                                if (validblockIDs.ContainsKey(ItemTypes.IndexLookup.GetName(blockID)))
                                {
                                    if (generators.ContainsKey(tocheck[i] + Vector3Int.forward))
                                    {
                                        batteries[pos].RecievePower(generators[tocheck[i] + Vector3Int.forward].HasPower(batteries[pos].PowerNeeded()));
                                        if (batteries[pos].PowerNeeded() == 0)
                                            break;
                                    }
                                    if (tocheck.Contains(tocheck[i] + Vector3Int.forward) == false)
                                    {
                                        tocheck.Add(tocheck[i] + Vector3Int.forward);
                                    }
                                }
                            }
                            if (World.TryGetTypeAt(tocheck[i] + Vector3Int.right, out blockID))
                            {
                                if (validblockIDs.ContainsKey(ItemTypes.IndexLookup.GetName(blockID)))
                                {
                                    if (generators.ContainsKey(tocheck[i] + Vector3Int.right))
                                    {
                                        batteries[pos].RecievePower(generators[tocheck[i] + Vector3Int.right].HasPower(batteries[pos].PowerNeeded()));
                                        if (batteries[pos].PowerNeeded() == 0)
                                            break;
                                    }
                                    if (tocheck.Contains(tocheck[i] + Vector3Int.right) == false)
                                    {
                                        tocheck.Add(tocheck[i] + Vector3Int.right);
                                    }
                                }
                            }
                            if (World.TryGetTypeAt(tocheck[i] + Vector3Int.left, out blockID))
                            {
                                if (validblockIDs.ContainsKey(ItemTypes.IndexLookup.GetName(blockID)))
                                {
                                    if (generators.ContainsKey(tocheck[i] + Vector3Int.left))
                                    {
                                        batteries[pos].RecievePower(generators[tocheck[i] + Vector3Int.left].HasPower(batteries[pos].PowerNeeded()));
                                        if (batteries[pos].PowerNeeded() == 0)
                                            break;
                                    }
                                    if (tocheck.Contains(tocheck[i] + Vector3Int.left) == false)
                                    {
                                        tocheck.Add(tocheck[i] + Vector3Int.left);
                                    }
                                }
                            }
                            if (World.TryGetTypeAt(tocheck[i] + Vector3Int.up, out blockID))
                            {
                                if (validblockIDs.ContainsKey(ItemTypes.IndexLookup.GetName(blockID)))
                                {
                                    if (generators.ContainsKey(tocheck[i] + Vector3Int.up))
                                    {
                                        batteries[pos].RecievePower(generators[tocheck[i] + Vector3Int.up].HasPower(batteries[pos].PowerNeeded()));
                                        if (batteries[pos].PowerNeeded() == 0)
                                            break;
                                    }
                                    if (tocheck.Contains(tocheck[i] + Vector3Int.up) == false)
                                    {
                                        tocheck.Add(tocheck[i] + Vector3Int.up);
                                    }
                                }
                            }
                            if (World.TryGetTypeAt(tocheck[i] + Vector3Int.down, out blockID))
                            {
                                if (validblockIDs.ContainsKey(ItemTypes.IndexLookup.GetName(blockID)))
                                {
                                    if (generators.ContainsKey(tocheck[i] + Vector3Int.down))
                                    {
                                        batteries[pos].RecievePower(generators[tocheck[i] + Vector3Int.down].HasPower(batteries[pos].PowerNeeded()));
                                        if (batteries[pos].PowerNeeded() == 0)
                                            break;
                                    }
                                    if (tocheck.Contains(tocheck[i] + Vector3Int.down) == false)
                                    {
                                        tocheck.Add(tocheck[i] + Vector3Int.down);
                                    }
                                }
                            }
                        }
                    }

                    foreach (Vector3Int pos in machines.Keys)
                    {
                        List<Vector3Int> tocheck = new List<Vector3Int>
                        {
                            pos
                        };

                        for (int i = 0; i < tocheck.Count; i++)
                        {
#pragma warning disable IDE0018 // Inline variable declaration
                            ushort blockID = 0;
#pragma warning restore IDE0018 // Inline variable declaration
                            if (World.TryGetTypeAt(tocheck[i] + Vector3Int.back, out blockID) && validblockIDs.ContainsKey(ItemTypes.IndexLookup.GetName(blockID)))
                            {
                                if (batteries.ContainsKey(tocheck[i] + Vector3Int.back))
                                {
                                    machines[pos].RecievePower(batteries[tocheck[i] + Vector3Int.back].HasPower(machines[pos].PowerNeeded()));
                                    if (machines[pos].PowerNeeded() == 0)
                                        break;
                                }
                                else if (generators.ContainsKey(tocheck[i] + Vector3Int.back))
                                {
                                    machines[pos].RecievePower(generators[tocheck[i] + Vector3Int.back].HasPower(machines[pos].PowerNeeded()));
                                    if (machines[pos].PowerNeeded() == 0)
                                        break;
                                }
                                if (tocheck.Contains(tocheck[i] + Vector3Int.back) == false)
                                {
                                    tocheck.Add(tocheck[i] + Vector3Int.back);
                                }
                            }
                            //Forward
                            if (World.TryGetTypeAt(tocheck[i] + Vector3Int.forward, out blockID) && validblockIDs.ContainsKey(ItemTypes.IndexLookup.GetName(blockID)))
                            {
                                if (batteries.ContainsKey(tocheck[i] + Vector3Int.forward))
                                {
                                    machines[pos].RecievePower(batteries[tocheck[i] + Vector3Int.forward].HasPower(machines[pos].PowerNeeded()));
                                    if (machines[pos].PowerNeeded() == 0)
                                        break;
                                }
                                else if (generators.ContainsKey(tocheck[i] + Vector3Int.forward))
                                {
                                    machines[pos].RecievePower(generators[tocheck[i] + Vector3Int.forward].HasPower(machines[pos].PowerNeeded()));
                                    if (machines[pos].PowerNeeded() == 0)
                                        break;
                                }
                                if (tocheck.Contains(tocheck[i] + Vector3Int.forward) == false)
                                {
                                    tocheck.Add(tocheck[i] + Vector3Int.forward);
                                }
                            }
                            //Right
                            if (World.TryGetTypeAt(tocheck[i] + Vector3Int.right, out blockID) && validblockIDs.ContainsKey(ItemTypes.IndexLookup.GetName(blockID)))
                            {
                                if (batteries.ContainsKey(tocheck[i] + Vector3Int.right))
                                {
                                    machines[pos].RecievePower(batteries[tocheck[i] + Vector3Int.right].HasPower(machines[pos].PowerNeeded()));
                                    if (machines[pos].PowerNeeded() == 0)
                                        break;
                                }
                                else if (generators.ContainsKey(tocheck[i] + Vector3Int.right))
                                {
                                    machines[pos].RecievePower(generators[tocheck[i] + Vector3Int.right].HasPower(machines[pos].PowerNeeded()));
                                    if (machines[pos].PowerNeeded() == 0)
                                        break;
                                }
                                if (tocheck.Contains(tocheck[i] + Vector3Int.right) == false)
                                {
                                    tocheck.Add(tocheck[i] + Vector3Int.right);
                                }
                            }
                            //Left
                            if (World.TryGetTypeAt(tocheck[i] + Vector3Int.left, out blockID) && validblockIDs.ContainsKey(ItemTypes.IndexLookup.GetName(blockID)))
                            {
                                if (batteries.ContainsKey(tocheck[i] + Vector3Int.left))
                                {
                                    machines[pos].RecievePower(batteries[tocheck[i] + Vector3Int.left].HasPower(machines[pos].PowerNeeded()));
                                    if (machines[pos].PowerNeeded() == 0)
                                        break;
                                }
                                else if (generators.ContainsKey(tocheck[i] + Vector3Int.left))
                                {
                                    machines[pos].RecievePower(generators[tocheck[i] + Vector3Int.left].HasPower(machines[pos].PowerNeeded()));
                                    if (machines[pos].PowerNeeded() == 0)
                                        break;
                                }
                                if (tocheck.Contains(tocheck[i] + Vector3Int.left) == false)
                                {
                                    tocheck.Add(tocheck[i] + Vector3Int.left);
                                }
                            }
                            //Up
                            if (World.TryGetTypeAt(tocheck[i] + Vector3Int.up, out blockID) && validblockIDs.ContainsKey(ItemTypes.IndexLookup.GetName(blockID)))
                            {
                                if (batteries.ContainsKey(tocheck[i] + Vector3Int.up))
                                {
                                    machines[pos].RecievePower(batteries[tocheck[i] + Vector3Int.up].HasPower(machines[pos].PowerNeeded()));
                                    if (machines[pos].PowerNeeded() == 0)
                                        break;
                                }
                                else if (generators.ContainsKey(tocheck[i] + Vector3Int.up))
                                {
                                    machines[pos].RecievePower(generators[tocheck[i] + Vector3Int.up].HasPower(machines[pos].PowerNeeded()));
                                    if (machines[pos].PowerNeeded() == 0)
                                        break;
                                }
                                if (tocheck.Contains(tocheck[i] + Vector3Int.up) == false)
                                {
                                    tocheck.Add(tocheck[i] + Vector3Int.up);
                                }
                            }
                            //Down
                            if (World.TryGetTypeAt(tocheck[i] + Vector3Int.down, out blockID) && validblockIDs.ContainsKey(ItemTypes.IndexLookup.GetName(blockID)))
                            {
                                if (batteries.ContainsKey(tocheck[i] + Vector3Int.down))
                                {
                                    machines[pos].RecievePower(batteries[tocheck[i] + Vector3Int.down].HasPower(machines[pos].PowerNeeded()));
                                    if (machines[pos].PowerNeeded() == 0)
                                        break;
                                }
                                else if (generators.ContainsKey(tocheck[i] + Vector3Int.down))
                                {
                                    machines[pos].RecievePower(generators[tocheck[i] + Vector3Int.down].HasPower(machines[pos].PowerNeeded()));
                                    if (machines[pos].PowerNeeded() == 0)
                                        break;
                                }
                                if (tocheck.Contains(tocheck[i] + Vector3Int.down) == false)
                                {
                                    tocheck.Add(tocheck[i] + Vector3Int.down);
                                }
                            }
                        }
                    }
                }
            }
        }

        internal static bool IsEnabled()
        {
            return Enabled;
        }
    }
}