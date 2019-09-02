using PhentrixGames.NewColonyAPI.Power;
using Pipliz;
using Pipliz.JSON;
using System.Collections.Generic;

namespace PhentrixGames.RiseoftheNewColonies.Teleporter
{
    [ModLoader.ModManager]
    public static class TeleporterManager
    {
        private static Dictionary<int, TeleporterData> portals = new Dictionary<int, TeleporterData>();
        private static Dictionary<Players.Player, UnityEngine.Vector3> lastpos = new Dictionary<Players.Player, UnityEngine.Vector3>();

        internal static bool SetKey(int colonyID, string key, Vector3Int location)
        {
            if (key.Length < 6)
                return false;

            foreach (var portal in portals)
            {
                if (key == portal.Value.teleportcode)
                {
                    return false;
                }
            }
            if (portals.ContainsKey(colonyID) == false)
            {
                portals.Add(colonyID, new TeleporterData(location, key));
            }
            else
            {
                portals[colonyID] = new TeleporterData(location, key);
            }
            Save();
            return true;
        }

        internal static void RemoveTeleporter(int colonyID, Vector3Int pos)
        {
            if (portals.ContainsKey(colonyID))
            {
                NewColonyAPI.Helpers.Chat.SendToAll("ID: " + colonyID + " exists!");
                if (portals[colonyID].location == pos.Add(-1, 0, 0))
                {
                    portals.Remove(colonyID);
                }
                if (portals[colonyID].location == pos.Add(1, 0, 0))
                {
                    portals.Remove(colonyID);
                }
                if (portals[colonyID].location == pos.Add(0, 0, -1))
                {
                    portals.Remove(colonyID);
                }
                if (portals[colonyID].location == pos.Add(0, 0, 1))
                {
                    portals.Remove(colonyID);
                }
            }
            Save();
        }

        internal static bool GetKey(int colonyID, out string output)
        {
            output = "";

            if (portals.ContainsKey(colonyID))
            {
                output = portals[colonyID].teleportcode;
                return true;
            }

            return false;
        }

        internal static void TeleportTo(Players.Player player, string teleportkey)
        {
            foreach (var portal in portals)
            {
                if (portal.Value.teleportcode == teleportkey)
                {
                    UnityEngine.Vector3 telepos = new UnityEngine.Vector3(portal.Value.location.x, portal.Value.location.y, portal.Value.location.z);
                    if (lastpos.ContainsKey(player))
                    {
                        lastpos[player] = player.Position;
                    }
                    else
                    {
                        lastpos.Add(player, player.Position);
                    }

                    Chatting.Commands.Teleport.TeleportTo(player, telepos);

                    player.Inventory.TryRemove(ItemTypes.IndexLookup.GetIndex("Recall Device"));
                    if (player.ActiveColony != null)
                        player.ActiveColony.Stockpile.TryRemove(ItemTypes.IndexLookup.GetIndex("Recall Device"));
                    player.Inventory.TryAdd(ItemTypes.IndexLookup.GetIndex("Recall Device"));
                    break;
                }
            }
        }

        internal static void TeleportBack(Players.Player player)
        {
            if (lastpos.ContainsKey(player))
            {
                Chatting.Commands.Teleport.TeleportTo(player, lastpos[player]);
                lastpos.Remove(player);
            }
            else
            {
                NewColonyAPI.Helpers.Chat.Send(player, "Last Position has expired!");
            }

            player.Inventory.TryRemove(ItemTypes.IndexLookup.GetIndex("Recall Device"));
            if (player.ActiveColony != null)
                player.ActiveColony.Stockpile.TryRemove(ItemTypes.IndexLookup.GetIndex("Recall Device"));
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterSelectedWorld, Entry.Naming + "LoadGeoDasher")]
        [ModLoader.ModCallbackDependsOn("PhentrixGames.NewColonyAPI.LoadTextures")]
        internal static void Init()
        {
            if (PowerManager.IsEnabled())
            {
                string saveloc = "";

                saveloc = NewColonyAPI.Helpers.Utilities.GetWorldJSONPath("portals.json");
                if (JSON.Deserialize(saveloc, out JSONNode initportals, false))
                {
                    foreach (var item in initportals.LoopArray())
                    {
                        portals.Add(item.GetAs<int>("id"), new TeleporterData(NewColonyAPI.Helpers.Utilities.NodeToVector3Int(item.GetAs<JSONNode>("location")), item.GetAs<string>("key")));
                    }
                }

                saveloc = NewColonyAPI.Helpers.Utilities.GetWorldJSONPath("recallinfo.json");
                if (JSON.Deserialize(saveloc, out JSONNode initrecall, false))
                {
                    foreach (var item in initrecall.LoopArray())
                    {
                        if (NetworkID.TryParse(item.GetAs<string>("id"), out NetworkID networkID))
                        {
                            lastpos.Add(Players.GetPlayer(networkID), item.GetAs<JSONNode>("location").ToVector3());
                        }
                    }
                }
            }
        }

        internal static void Save()
        {
            if (PowerManager.IsEnabled())
            {
                string saveloc = "";
                JSONNode parent;

                parent = new JSONNode(NodeType.Array);
                saveloc = NewColonyAPI.Helpers.Utilities.GetWorldJSONPath("portals.json");
                foreach (var portal in portals)
                {
                    JSONNode child = new JSONNode(NodeType.Object);
                    child.SetAs("id", portal.Key);
                    child.SetAs("key", portal.Value.teleportcode);
                    child.SetAs("location", NewColonyAPI.Helpers.Utilities.Vector3IntToNode(portal.Value.location));
                    parent.AddToArray(child);
                }
                JSON.Serialize(saveloc, parent);

                parent = new JSONNode(NodeType.Array);
                saveloc = NewColonyAPI.Helpers.Utilities.GetWorldJSONPath("recallinfo.json");
                foreach (var pos in lastpos)
                {
                    JSONNode child = new JSONNode(NodeType.Object);
                    child.SetAs("id", pos.Key.ID.ToString());
                    child.SetAs("location", pos.Value.ToJSON());
                    parent.AddToArray(child);
                }
                JSON.Serialize(saveloc, parent);
            }
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnChangedBlock, Entry.Naming + "OnRemoveGeoDasher")]
        public static void OnChangedBlock(ModLoader.OnTryChangeBlockData blockData)
        {
            if (blockData.RequestOrigin.Type == BlockChangeRequestOrigin.EType.Player)
            {
                if (blockData.RequestOrigin.AsPlayer.ActiveColony != null)
                {
                    if (blockData.TypeOld.Name.Contains("Geo Dasher"))
                    {
                        RemoveTeleporter(blockData.RequestOrigin.AsPlayer.ActiveColony.ColonyID, blockData.Position);
                    }
                }
            }
        }
    }
}