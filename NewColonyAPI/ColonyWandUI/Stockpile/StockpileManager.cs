using Pipliz.JSON;
using System.Collections.Generic;

namespace PhentrixGames.NewColonyAPI.ColonyWandUI.Stockpile
{
    internal static class StockpileManager
    {
        private static Dictionary<int, OldStockpiles> oldstockpileinfo = new Dictionary<int, OldStockpiles>();
        private static bool Enabled = false;

        internal static void Init()
        {
            Enabled = true;
        }

        public static bool GetOldStockpiles(int colonyid, out OldStockpiles oldStockpiles)
        {
            oldStockpiles = null;
            if (oldstockpileinfo.ContainsKey(colonyid))
            {
                oldStockpiles = oldstockpileinfo[colonyid];
                return true;
            }
            return false;
        }

        private static bool canupdate = false;

        public static void UpdateInfo()
        {
            if (Enabled)
            {
                if (canupdate == true && TimeCycle.TimeOfDayHours < 1)
                {
                    canupdate = false;

                    foreach (var colony in ServerManager.ColonyTracker.ColoniesByID)
                    {
                        if (oldstockpileinfo.ContainsKey(colony.Key))
                        {
                            oldstockpileinfo[colony.Key].NewDay();
                        }
                        else
                        {
                            oldstockpileinfo.Add(colony.Key, new OldStockpiles());
                        }
                    }
                }
                if (canupdate == false && TimeCycle.TimeOfDayHours > 1)
                {
                    canupdate = true;
                }
            }
        }

        public static void ProduceConsume(int colonyid, Recipes.Recipe recipe, List<Recipes.RecipeResult> results)
        {
            if (oldstockpileinfo.ContainsKey(colonyid) == false)
            {
                oldstockpileinfo.Add(colonyid, new OldStockpiles());
            }
            foreach (var item in recipe.Requirements)
            {
                AddRemove(colonyid, item.Type, -item.Amount);
            }
            foreach (var item in results)
            {
                AddRemove(colonyid, item.Type, item.Amount);
            }
        }

        public static void ProduceConsume(int colonyid, List<ItemTypes.ItemTypeDrops> items)
        {
            if (oldstockpileinfo.ContainsKey(colonyid) == false)
            {
                oldstockpileinfo.Add(colonyid, new OldStockpiles());
            }
            foreach (var item in items)
            {
                AddRemove(colonyid, item.Type, item.Amount);
            }
        }

        public static void GuardShot(int colonyid, List<InventoryItem> items)
        {
            if (oldstockpileinfo.ContainsKey(colonyid))
            {
                foreach (var item in items)
                {
                    AddRemove(colonyid, item.Type, -item.Amount);
                }
            }
            else
            {
                oldstockpileinfo.Add(colonyid, new OldStockpiles());
                foreach (var item in items)
                {
                    AddRemove(colonyid, item.Type, -item.Amount);
                }
            }
        }

        private static void AddRemove(int colonyid, ushort itemid, int amount)
        {
            if (oldstockpileinfo[colonyid].today.ContainsKey(itemid))
            {
                oldstockpileinfo[colonyid].today[itemid] += amount;
            }
            else
            {
                oldstockpileinfo[colonyid].today.Add(itemid, amount);
            }
        }

        public static OldStockpiles GetOldStockpiles(int colonyid)
        {
            if (oldstockpileinfo.ContainsKey(colonyid))
            {
                return oldstockpileinfo[colonyid];
            }
            return null;
        }

        public static void Save()
        {
            if (Enabled)
            {
                JSONNode parent = new JSONNode(NodeType.Array);
                foreach (var item in oldstockpileinfo)
                {
                    JSONNode itemNode = new JSONNode(NodeType.Object);
                    itemNode.SetAs("colonyID", item.Key);

                    JSONNode t = new JSONNode(NodeType.Array);
                    foreach (var today in item.Value.today)
                    {
                        JSONNode tmp = new JSONNode(NodeType.Object);
                        tmp.SetAs("id", today.Key);
                        tmp.SetAs("amnt", today.Value);
                        t.AddToArray(tmp);
                    }
                    itemNode.SetAs("today", t);

                    JSONNode y = new JSONNode(NodeType.Array);
                    foreach (var yesterday in item.Value.yesterday)
                    {
                        JSONNode tmp = new JSONNode(NodeType.Object);
                        tmp.SetAs("id", yesterday.Key);
                        tmp.SetAs("amnt", yesterday.Value);
                        y.AddToArray(tmp);
                    }
                    itemNode.SetAs("yesterday", y);

                    JSONNode z = new JSONNode(NodeType.Array);
                    foreach (var twodaysago in item.Value.twodaysago)
                    {
                        JSONNode tmp = new JSONNode(NodeType.Object);
                        tmp.SetAs("id", twodaysago.Key);
                        tmp.SetAs("amnt", twodaysago.Value);
                        z.AddToArray(tmp);
                    }
                    itemNode.SetAs("twodaysago", z);

                    parent.AddToArray(itemNode);
                }
                JSON.Serialize(Helpers.Utilities.GetWorldJSONPath("resourceproduction.json"), parent);
            }
        }

        public static void Load()
        {
            if (JSON.Deserialize(Helpers.Utilities.GetWorldJSONPath("resourceproduction.json"), out JSONNode node, false))
            {
                foreach (var parent in node.LoopArray())
                {
                    int cid = parent.GetAs<int>("colonyID");
                    oldstockpileinfo.Add(cid, new OldStockpiles());
                    JSONNode today = parent.GetAs<JSONNode>("today");
                    foreach (var item in today.LoopArray())
                    {
                        oldstockpileinfo[cid].today.Add(item.GetAs<ushort>("id"), item.GetAs<int>("amnt"));
                    }
                    JSONNode yesterday = parent.GetAs<JSONNode>("yesterday");
                    foreach (var item in yesterday.LoopArray())
                    {
                        oldstockpileinfo[cid].yesterday.Add(item.GetAs<ushort>("id"), item.GetAs<int>("amnt"));
                    }
                    JSONNode twodaysago = parent.GetAs<JSONNode>("twodaysago");
                    foreach (var item in twodaysago.LoopArray())
                    {
                        oldstockpileinfo[cid].twodaysago.Add(item.GetAs<ushort>("id"), item.GetAs<int>("amnt"));
                    }
                }
            }
        }
    }
}