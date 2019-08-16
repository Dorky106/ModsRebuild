using Jobs;
using NPC;
using Pipliz.JSON;
using System;
using System.Collections.Generic;
using System.IO;

namespace PhentrixGames.NewColonyAPI.NPCXP
{
    [ModLoader.ModManager]
    public static class NPCManager
    {
        private static Dictionary<int, NPCData> NPCDataList = null;
        private static JSONNode NPCMaleNameList = new JSONNode(NodeType.Array);
        private static JSONNode NPCFemaleNameList = new JSONNode(NodeType.Array);
        private static JSONNode NPCLastNameList = new JSONNode(NodeType.Array);

        internal static bool Aging
        {
            get;
            private set;
        }

        internal static bool Enabled
        {
            get;
            private set;
        }

        internal static bool Silent
        {
            get;
            private set;
        }

        public static int baseXP = 10;
        public static int maxLevel = 25;
        public static float XPMultiplier = 2;
        public static float EfficiencyPerLevel = 0.05f;
        private static float MaxEfficiency = 0.5f;
        public static float GatherEfficiencyPerLevel = 0.05f;
        private static float MaxGatherEfficiencyPerLevel = 0.5f;

        public static bool Initialized = false;

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesDefined, NewColonyAPIEntry.Naming + "NPCManager")]
        [ModLoader.ModCallbackDependsOn("pipliz.server.loadnpctypes")]
        public static void Initialize()
        {
            Enabled = Configuration.ConfigManager.GetConfigBooleanOrDefault(NewColonyAPIEntry.ModName, "npcs.enabled", true);
            if (Enabled)
            {
                NPCDataList = new Dictionary<int, NPCData>();
                foreach (var info in NPCDataList)
                {
                    Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, info.Key.ToString(), Helpers.Logging.LogType.Info);
                }

                Aging = Configuration.ConfigManager.GetConfigBooleanOrDefault(NewColonyAPIEntry.ModName, "npcs.aging", false);
                Silent = Configuration.ConfigManager.GetConfigBooleanOrDefault(NewColonyAPIEntry.ModName, "npcs.silent", true);
                baseXP = Configuration.ConfigManager.GetConfigIntOrDefault(NewColonyAPIEntry.ModName, "npcs.baseXP", 25);
                maxLevel = Configuration.ConfigManager.GetConfigIntOrDefault(NewColonyAPIEntry.ModName, "npcs.maxLevel", 5);
                XPMultiplier = Configuration.ConfigManager.GetConfigFloatOrDefault(NewColonyAPIEntry.ModName, "npcs.xpMultiplier", 2);
                EfficiencyPerLevel = Configuration.ConfigManager.GetConfigFloatOrDefault(NewColonyAPIEntry.ModName, "npcs.efficiencyPerLevel", 0.2f);
                if (maxLevel > 50)
                {
                    maxLevel = 50;
                }
                if (((float)maxLevel * EfficiencyPerLevel) > MaxEfficiency)
                {
                    Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Lowering EfficiencyPerLevel to be under 50%!", Helpers.Logging.LogType.Loading);
                    while (maxLevel * EfficiencyPerLevel >= MaxEfficiency)
                    {
                        EfficiencyPerLevel = (float)Math.Round((EfficiencyPerLevel - 0.01f) * 100f) / 100f;
                    }
                    Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Finished lowering EfficiencyPerLevel to be under 50%!", Helpers.Logging.LogType.Loading);
                }

                //Helpers.Utilities.WriteLog("New Colony API", String.Format("NPC Config: baseXP: {0}, maxLevel: {1}, xpMultiplier: {2}, efficiencyPerLevel: {3}", baseXP, maxLevel, XPMultiplier, EfficiencyPerLevel), Helpers.Utilities.LogType.Info);
                if (JSON.Deserialize(Helpers.Utilities.MultiCombine(NewColonyAPIEntry.ModSettingsDirectory, "npcmalenames.json"), out JSONNode malearray, false))
                {
                    NPCMaleNameList = malearray;
                    Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Loaded NPC Male Names List " + NPCMaleNameList.ChildCount, Helpers.Logging.LogType.Loading);
                }
                else
                {
                    JSONNode j = new JSONNode(NodeType.Array);
                    j.SetAs<string>("Dave");
                    NPCMaleNameList.AddToArray(j);

                    Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Failed to load NPC Male Names List - assumed Dave", Helpers.Logging.LogType.Issue);
                }
                if (JSON.Deserialize(Helpers.Utilities.MultiCombine(NewColonyAPIEntry.ModSettingsDirectory, "npcfemalenames.json"), out JSONNode femalearray, false))
                {
                    NPCFemaleNameList = femalearray;
                    Helpers.Logging.WriteLog("New Colony API", "Loaded NPC Female Names List " + NPCFemaleNameList.ChildCount, Helpers.Logging.LogType.Loading);
                }
                else
                {
                    JSONNode j = new JSONNode(NodeType.Array);
                    j.SetAs<string>("Sarah");
                    NPCFemaleNameList.AddToArray(j);

                    Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Failed to load NPC Female Name List - assumed Sarah", Helpers.Logging.LogType.Issue);
                }
                if (JSON.Deserialize(Helpers.Utilities.MultiCombine(NewColonyAPIEntry.ModSettingsDirectory, "npcsurnames.json"), out JSONNode lastarray, false))
                {
                    NPCLastNameList = lastarray;
                    Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Loaded NPC Last Names List " + NPCLastNameList.ChildCount, Helpers.Logging.LogType.Loading);
                }
                else
                {
                    JSONNode j = new JSONNode(NodeType.Array);
                    j.SetAs<string>("Smith");
                    NPCLastNameList.AddToArray(j);

                    Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Failed to load NPC Last Names List - assumed Smith", Helpers.Logging.LogType.Issue);
                }

                LoadNPCData();
                Initialized = true;
            }
        }

        public static void ClearJobType(string i)
        {
            //JobSys.BlockJobManagerTracker.ClearType(i);
        }

        //GetAndUpdate
        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnNPCCraftedRecipe, NewColonyAPIEntry.Naming + "OnNPCCraftedRecipe")]
        internal static void OnNPCCraftedRecipe(IJob job, Recipes.Recipe recipe, List<Recipes.RecipeResult> results)
        {
            if (Enabled)
            {
                NPCData npcdata = GetNPCData(job.NPC.ID, job.NPC.Colony);
                npcdata.XPData.AddXP(job.NPC.ID, job.NPCType.ToString(), job.NPC.Colony);
                UpdateNPCData(job.NPC.ID, npcdata);
                //Managers.StockpileManager.ProduceConsume(job.NPC.Colony.ColonyID, recipe, results);
            }
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnNPCGathered, NewColonyAPIEntry.Naming + "OnNPCGathered")]
        public static void OnNPCGathered(IJob job, Pipliz.Vector3Int pos, List<ItemTypes.ItemTypeDrops> items)
        {
            if (Enabled)
            {
                NPCData npcData = NPCManager.GetNPCData(job.NPC.ID, job.NPC.Colony);
                int chance = (int)(100 * npcData.XPData.GetGatherChance(job.NPCType.ToString()));

                Helpers.RandomChance randomChance = new Helpers.RandomChance();
                int[] chances = new int[] { 100 - chance, chance };
                //0 = No Bonus Item
                //1 = Bonus Item
                int[] choices = new int[] { 0, 1 };
                if (randomChance.WeightChance(chances, choices) == 1)
                {
                    List<ItemTypes.ItemTypeDrops> bonus = new List<ItemTypes.ItemTypeDrops>();
                    foreach (var item in items)
                    {
                        bonus.Add(new ItemTypes.ItemTypeDrops(item.item.Type, 1));
                    }
                    items.AddRange(bonus);
                }

                NPCData npcdata = GetNPCData(job.NPC.ID, job.NPC.Colony);
                npcdata.XPData.AddXP(job.NPC.ID, job.NPCType.ToString(), job.NPC.Colony);
                UpdateNPCData(job.NPC.ID, npcdata);
                //Managers.StockpileManager.ProduceConsume(job.NPC.Colony.ColonyID, items);
            }
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnMonsterHit, NewColonyAPIEntry.Naming + "OnMonsterHit")]
        public static void OnMonsterHit(Monsters.IMonster monster, ModLoader.OnHitData hitData)
        {
            if (hitData.HitSourceType == ModLoader.OnHitData.EHitSourceType.NPC)
            {
                NPC.NPCBase npc = (NPC.NPCBase)hitData.HitSourceObject as NPC.NPCBase;

                NPCData npcdata = GetNPCData(npc.ID, npc.Colony);
                npcdata.XPData.AddXP(npc.ID, npc.Job.NPCType.ToString(), npc.Colony);
                UpdateNPCData(npc.ID, npcdata);

                GuardJobInstance guard = (GuardJobInstance)npc.Job as GuardJobInstance;
                GuardJobSettings settings = (GuardJobSettings)guard.Settings as GuardJobSettings;
                //Managers.StockpileManager.GuardShot(npc.Colony.ColonyID, settings.ShootItem);
                if (settings.OnShootResultItem.item.Type > 0 && Pipliz.Random.NextDouble(0.0, 1.0) <= (double)settings.OnShootResultItem.chance)
                {
                    //Managers.StockpileManager.GuardShot(npc.Colony.ColonyID, new System.Collections.Generic.List<InventoryItem>()
                    //{
                    //    new InventoryItem(settings.OnShootResultItem.Type, -settings.OnShootResultItem.Amount)
                    //});
                }
            }
        }

        public static NPCData GetNPCData(int id, Colony owner)
        {
            if (NPCDataList.ContainsKey(id))
            {
                return NPCDataList[id];
            }
            else
            {
                NPCData d = new NPCData(owner);
                NPCDataList.Add(id, d);
                return d;
            }
        }

        public static bool NpcExists(int i)
        {
            if (NPCDataList.ContainsKey(i))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void UpdateNPCData(int id, NPCData d)
        {
            NPCDataList[id] = d;
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnNPCDied, NewColonyAPIEntry.Naming + "RemoveNPCData")]
        public static void RemoveNPCData(NPC.NPCBase npc)
        {
            if (NPCDataList.ContainsKey(npc.ID))
            {
                NPCDataList.Remove(npc.ID);
            }
        }

        public static void SaveNPCData()
        {
            try
            {
                string jSONPath = GetJSONPath();
                Helpers.Utilities.MakeDirectoryIfNeeded(jSONPath);
                if (NPCDataList.Count == 0)
                {
                    File.Delete(jSONPath);
                }
                else
                {
                    // make a JSON node
                    JSONNode rootnode = new JSONNode(NodeType.Array);

                    // then go through stuff
                    foreach (int npcID in NPCDataList.Keys)
                    {
                        NPCData npcData = NPCDataList[npcID];

                        // build a child node
                        JSONNode child = new JSONNode(NodeType.Object);

                        // Create the JSON
                        child.SetAs("id", npcID);
                        child.SetAs("age", npcData.Age.Years + "." + npcData.Age.Months);
                        child.SetAs("owner", npcData.Owner.ColonyID);
                        child.SetAs("xpdata", npcData.XPData.ToJSON());
                        child.SetAs("name", npcData.Name);

                        rootnode.AddToArray(child);
                    }

                    Pipliz.JSON.JSON.Serialize(jSONPath, rootnode, 99);
                }
            }
            catch (Exception exception2)
            {
                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Exception in saving all NPC Data:" + exception2.Message, Helpers.Logging.LogType.Error);
            }
        }

        public static void LoadNPCData()
        {
            try
            {
                if (JSON.Deserialize(GetJSONPath(), out JSONNode array, false))
                {
                    if (array != null)
                    {
                        foreach (JSONNode node in array.LoopArray())
                        {
                            try
                            {
                                int npcID = node["id"].GetAs<int>();

                                node.TryGetAsOrDefault<string>("age", out string age, "0.0");

                                //Helpers.Utilities.WriteLog("New Colony API", "Loading NPC:" + npcID, Helpers.Utilities.LogType.Info);
                                int ownerU = node["owner"].GetAs<int>();
                                Colony owner = ServerManager.ColonyTracker.ColoniesByID[ownerU];

                                if (NPCDataList.ContainsKey(npcID) == false)
                                {
                                    //doesn't exist, add it!
                                    NPCData npcData = new NPCData(owner, age);

                                    //Helpers.Utilities.WriteLog("New Colony API", String.Format("ID: {0}, ownerU: {1}", npcID, ownerU), Helpers.Utilities.LogType.Info);
                                    JSONNode xpdata = node["xpdata"].GetAs<JSONNode>();

                                    if (xpdata.ChildCount > 0)
                                    {
                                        foreach (KeyValuePair<string, JSONNode> current in xpdata.LoopObject())
                                        {
                                            npcData.XPData.SetXP(current.Key, current.Value.GetAs<ushort>());
                                            //Utilities.WriteLog("New Colony API", "Added XP: " + current.Key + " value: " + current.Value.GetAs<ushort>());
                                        }
                                    }
                                    npcData.XPData.RecalculateAllLevels();

                                    string npcName = node["name"].GetAs<string>();
                                    npcData.Name = npcName;

                                    NPCDataList.Add(npcID, npcData);
                                }
                            }
                            catch (Exception exception)
                            {
                                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Exception loading NPC data;" + exception.Message, Helpers.Logging.LogType.Error);
                            }
                        }

                        Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Loaded NPCData", Helpers.Logging.LogType.Info);
                    }
                    else
                    {
                        Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Loading NPC data returned 0 results", Helpers.Logging.LogType.Info);
                    }
                }
                else
                {
                    Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Found no NPC Data (read error?)", Helpers.Logging.LogType.Issue);
                }
            }
            catch (Exception exception2)
            {
                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Exception in loading NPC data:" + exception2.Message, Helpers.Logging.LogType.Error);
            }
        }

        private static string GetJSONPath()
        {
            return "gamedata/savegames/" + ServerManager.WorldName + "/cppnpcxp.json";
        }

        public static string GetRandomName()
        {
            return GetRandomFirstName() + " " + GetRandomLastName();
        }

        private static string GetRandomFirstName()
        {
            string name = "";

            Random random = new Random();
            switch (random.Next(0, 2))
            {
                case 0:
                    if (NPCMaleNameList.ChildCount != 1)
                        name = NPCMaleNameList[random.Next(0, NPCMaleNameList.ChildCount)].GetAs<string>();
                    else
                        name = "Dave";
                    break;

                case 1:
                    if (NPCFemaleNameList.ChildCount != 1)
                        name = NPCFemaleNameList[random.Next(0, NPCMaleNameList.ChildCount)].GetAs<string>();
                    else
                        name = "Sarah";
                    break;
            }
            return name;
        }

        private static string GetRandomLastName()
        {
            Random random = new Random();
            int maxN = NPCLastNameList.ChildCount;

            string name = "";
            if (NPCLastNameList.ChildCount != 1)
                name = NPCLastNameList[random.Next(0, NPCLastNameList.ChildCount)].GetAs<string>();
            else
                name = "Smith";
            return name;
        }

        private static bool aged = false;

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnFixedUpdate, NewColonyAPIEntry.Naming + "AgeNPCs")]
        internal static void AgeNPCs()
        {
            if (Aging)
            {
                if ((TimeCycle.TimeOfDayHours >= 0 && TimeCycle.TimeOfDayHours < 1) && aged == true)
                {
                    aged = false;

                    List<int> deathnpcs = new List<int>();

                    foreach (var item in NPCDataList.Keys)
                    {
                        NPCDataList[item].NPCAgeUp();
                        if (NPCDataList[item].Age.Years >= 60)
                        {
                            if (NPCDataList[item].Age.Years >= 101)
                            {
                                NPC.NPCTracker.TryGetNPC(item, out NPC.NPCBase npc);
                                deathnpcs.Add(npc.ID);
                                continue;
                            }

                            Random randomChance = new Random();
                            int chance = 2 * (NPCDataList[item].Age.Years - 60);
                            int deathchance = 100 - chance;
                            if (randomChance.Next(101) <= deathchance)
                            {
                                if (NPCTracker.TryGetNPC(item, out NPCBase npc))
                                {
                                    deathnpcs.Add(npc.ID);
                                    Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, npc.ID + " : " + NPCDataList[item].Name + " is gonna die", Helpers.Logging.LogType.Info);
                                }
                            }
                        }
                    }

                    for (int i = deathnpcs.Count - 1; i >= 0; i--)
                    {
                        if (NPCTracker.TryGetNPC(deathnpcs[i], out NPCBase npc))
                        {
                            Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, npc.ID.ToString(), Helpers.Logging.LogType.Info);
                            Colony colony = npc.Colony;
                            string jobname = null;
                            if (npc.Job != null)
                            {
                                if (NPCType.NPCTypes.TryGetValue(npc.Job.NPCType, out INPCTypeSettings nPCTypeSettings))
                                {
                                    jobname = nPCTypeSettings.PrintName;
                                }
                            }
                            npc.OnDeath();

                            ThreadManager.InvokeOnMainThread(() =>
                            {
                                NPCBase newguy = new NPCBase(colony, colony.GetRandomBanner().Position);

                                colony.RegisterNPC(newguy);

                                NPCTracker.Add(newguy);

                                /*
                                IJob newjob = null;
                                List<IJob> jobs = colony?.JobFinder?.JobsData?.OpenJobs;
                                foreach (IJob job in jobs)
                                {
                                    if (NPCType.NPCTypes.TryGetValue(job.NPCType, out INPCTypeSettings nPCTypeSettings))
                                    {
                                        if (nPCTypeSettings.PrintName == jobname)
                                        {
                                            newjob = job;
                                            break;
                                        }
                                    }
                                }
                                if (newguy.IsValid)
                                {
                                    if (newjob != null && newjob.IsValid && newjob.NeedsNPC)
                                    {
                                        newguy.ClearJob();
                                        newguy.TakeJob(newjob);
                                    }
                                }
                                */
                                colony.SendCommonData();
                            }, 20);
                        }
                    }
                    /*
                    foreach (var deathnpc in deathnpcs)
                    {
                        NPC.NPCTracker.TryGetNPC(deathnpc, out NPC.NPCBase npc);
                        Colony colony = npc.Colony;
                        NPC.NPCBase newguy = new NPC.NPCBase(colony, colony.GetRandomBanner().Position);
                        npc.OnDeath();
                        colony.RegisterNPC(newguy);
                        ModLoader.Callbacks.OnNPCRecruited.Invoke(newguy);
                    }
                    */
                }

                if (TimeCycle.TimeOfDayHours >= 1)
                {
                    aged = true;
                }
            }
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnNPCHit, NewColonyAPIEntry.Naming + "OnNPCHit")]
        internal static void OnNPCHit(NPC.NPCBase npc, ModLoader.OnHitData hitData)
        {
            if (hitData.HitSourceType == ModLoader.OnHitData.EHitSourceType.PlayerClick)
            {
                Players.Player player = hitData.HitSourceObject as Players.Player;
                if (player.ActiveColony == npc.Colony)
                {
                    int menuWidth = 150;
                    NetworkUI.NetworkMenu menu = new NetworkUI.NetworkMenu();
                    NPCData npcData = GetNPCData(npc.ID, npc.Colony);
                    XPData xpData = npcData.XPData;

                    List<ValueTuple<NetworkUI.IItem, int>> age = new List<(NetworkUI.IItem, int)>();
                    age.Add(ValueTuple.Create<NetworkUI.IItem, int>(new NetworkUI.Items.Label("Age:"), menuWidth));
                    age.Add(ValueTuple.Create<NetworkUI.IItem, int>(new NetworkUI.Items.Label(npcData.Age.Years.ToString() + " years old"), menuWidth));
                    menu.Items.Add(new NetworkUI.Items.HorizontalRow(age));

                    List<ValueTuple<NetworkUI.IItem, int>> tops = new List<(NetworkUI.IItem, int)>();
                    tops.Add(ValueTuple.Create<NetworkUI.IItem, int>(new NetworkUI.Items.Label("Job"), menuWidth));
                    tops.Add(ValueTuple.Create<NetworkUI.IItem, int>(new NetworkUI.Items.Label("Level"), menuWidth));
                    tops.Add(ValueTuple.Create<NetworkUI.IItem, int>(new NetworkUI.Items.Label("Action Speed"), menuWidth));
                    menu.Items.Add(new NetworkUI.Items.HorizontalRow(tops));

                    foreach (string id in xpData.XPLevels.Keys)
                    {
                        if (JobManager.GetJobData(npc.NPCType, out JobData jobData))
                        {
                            List<ValueTuple<NetworkUI.IItem, int>> items = new List<(NetworkUI.IItem, int)>();
                            items.Add(ValueTuple.Create<NetworkUI.IItem, int>(new NetworkUI.Items.Label(id), menuWidth));
                            items.Add(ValueTuple.Create<NetworkUI.IItem, int>(new NetworkUI.Items.Label(xpData.XPLevels[id].ToString()), menuWidth));
                            items.Add(ValueTuple.Create<NetworkUI.IItem, int>(
                                new NetworkUI.Items.Label(
                                    (jobData.cooldown * xpData.GetCraftingMultiplier(id)).ToString()),
                                menuWidth));
                            menu.Items.Add(new NetworkUI.Items.HorizontalRow(items));
                        }
                    }

                    menu.LocalStorage.SetAs("header", npcData.Name);
                    NetworkUI.NetworkMenuManager.SendServerPopup(player, menu);
                }
                hitData.ResultDamage = 0;
            }
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnNPCJobChanged, NewColonyAPIEntry.Naming + "OnNPCJobChanged")]
        internal static void OnNPCJobChanged((NPC.NPCBase npc, IJob oldJob, IJob newJob) data)
        {
            if (Enabled)
            {
                if (data.npc != null)
                {
                    if (data.newJob != null)
                    {
                        JobData jobData = null;
                        if (JobManager.GetJobData(data.newJob.NPCType, out jobData))
                        {
                            switch (jobData.jobtype)
                            {
                                case "craftingblocknearwater":
                                    try
                                    {
                                        CraftingJobWaterInstance craftingblocknearwater = (CraftingJobWaterInstance)data.newJob as CraftingJobWaterInstance;
                                        craftingblocknearwater.Settings = new ImprovedCraftingWaterSettings(data.npc, (CraftingJobWaterSettings)craftingblocknearwater.Settings as CraftingJobWaterSettings);
                                    }
                                    catch (Exception e)
                                    {
                                        Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Error converting CraftingJobWaterSettings to ImprovedCraftingWaterSettings: " + e.Message + " : " + e.StackTrace, Helpers.Logging.LogType.Issue);
                                    }
                                    break;

                                case "craftingblock":
                                    try
                                    {
                                        CraftingJobInstance craftingblock = (CraftingJobInstance)data.newJob as CraftingJobInstance;
                                        craftingblock.Settings = new ImprovedCraftingSettings(data.npc, (CraftingJobSettings)craftingblock.Settings as CraftingJobSettings);
                                    }
                                    catch (Exception e)
                                    {
                                        Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Error converting CraftingJobSettings to ImprovedCraftingSettings: " + e.Message + " : " + e.StackTrace, Helpers.Logging.LogType.Issue);
                                    }
                                    break;

                                case "craftingblockrotated":
                                    try
                                    {
                                        CraftingJobInstance craftingblockrotated = (CraftingJobInstance)data.newJob as CraftingJobInstance;
                                        craftingblockrotated.Settings = new ImprovedCraftingJobRotatedSettings(data.npc, (CraftingJobRotatedSettings)craftingblockrotated.Settings as Jobs.CraftingJobRotatedSettings);
                                    }
                                    catch (Exception e)
                                    {
                                        Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Error converting CraftingJobRotatedSettings to ImprovedCraftingJobRotatedSettings: " + e.Message + " : " + e.StackTrace, Helpers.Logging.LogType.Issue);
                                    }
                                    break;

                                case "crafingblockrotatedlit":
                                    try
                                    {
                                        CraftingJobInstance craftingblockrotatedlit = (CraftingJobInstance)data.newJob as CraftingJobInstance;
                                        craftingblockrotatedlit.Settings = new ImprovedCraftingJobRotatedLitSettings(data.npc, (CraftingJobRotatedLitSettings)craftingblockrotatedlit.Settings as CraftingJobRotatedLitSettings);
                                    }
                                    catch (Exception e)
                                    {
                                        Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Error converting CraftingJobRotatedLitSettings to ImprovedCraftingJobRotatedLitSettings: " + e.Message + " : " + e.StackTrace, Helpers.Logging.LogType.Issue);
                                    }
                                    break;

                                case "guard":
                                    try
                                    {
                                        GuardJobInstance guard = (GuardJobInstance)data.newJob as GuardJobInstance;
                                        GuardJobSettings settings = (GuardJobSettings)guard.Settings as GuardJobSettings;
                                        GuardJobSettingData settingData = new GuardJobSettingData()
                                        {
                                            blockType = settings.BlockTypes[0].ToString(),
                                            npcType = settings.NPCTypeKey,
                                            sleepType = settings.SleepType,
                                            damage = settings.Damage,
                                            range = settings.Range,
                                            cooldownShot = settings.CooldownShot,
                                            onShootAudio = settings.OnShootAudio,
                                            onHitAudio = settings.OnHitAudio,
                                            shootRequirements = settings.ShootItem,
                                            recruitmentItem = settings.RecruitmentItem,
                                            onShootResult = settings.OnShootResultItem
                                        };
                                        guard.Settings = new ImprovedGuardJobSettings(data.npc, settingData);
                                    }
                                    catch (Exception e)
                                    {
                                        Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Error converting GuardJobSettings to ImprovedGuardJobSettings: " + e.Message + " : " + e.StackTrace, Helpers.Logging.LogType.Issue);
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnAutoSaveWorld, NewColonyAPIEntry.Naming + "OnAutoSaveWorld")]
        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnQuit, NewColonyAPIEntry.Naming + "OnQuit")]
        internal static void OnAutoSaveWorld()
        {
            SaveNPCData();
        }
    }
}