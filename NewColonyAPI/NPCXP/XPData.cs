using System;
using System.Collections.Generic;

namespace PhentrixGames.NewColonyAPI.NPCXP
{
    public class XPData
    {
        public Dictionary<string, ulong> XPAmounts;
        public Dictionary<string, int> XPLevels;

        public XPData()
        {
            XPAmounts = new Dictionary<string, ulong>();
            XPLevels = new Dictionary<string, int>();
        }

        public void AddXP(int npcID, string jobtype, Colony owner, ushort amount = 1)
        {
            AddXPAmount(npcID, jobtype, amount, owner);
        }

        public void AddXPAmount(int npcID, string jobtype, ushort amount, Colony owner)
        {
            if (GetLevel(jobtype) != NPCManager.maxLevel)
            {
                if (XPAmounts.ContainsKey(jobtype))
                {
                    XPAmounts[jobtype] += amount;
                }
                else
                {
                    XPAmounts.Add(jobtype, amount);
                }
                if (XPLevels.ContainsKey(jobtype))
                {
                    //Utilities.WriteLog("Level: " + XPLevels[jobtype] + "/" + getLevel(jobtype));
                    if (GetLevel(jobtype) > XPLevels[jobtype])
                    {
                        NPCData n = NPCManager.GetNPCData(npcID, owner);
                        // the NPC has levelled up!
                        XPLevels[jobtype] += 1;
                        if (NPCManager.Silent == false)
                        {
                            foreach (Players.Player own in owner.Owners)
                            {
                                Helpers.Chat.Send(own, String.Format("{0} [{1}] has gained a level in {2} (Level: {3}, {4}% efficiency boost)", n.Name, npcID, jobtype, XPLevels[jobtype], Math.Round((1 - GetCraftingMultiplier(jobtype)) * 100, 0)), Helpers.Chat.ChatColour.orange);
                            }
                        }
                    }
                }
                else
                {
                    //Utilities.WriteLog("Job type level: " + jobtype + " does not exist, adding...");
                    XPLevels.Add(jobtype, 0);
                }
            }
            //Utilities.WriteLog("Updated XP for NPC for job " + jobtype + " added " + amount + "XP to total " + XPAmounts[jobtype]);
        }

        public void SetXP(string jobtype, ushort amount)
        {
            if (XPAmounts.ContainsKey(jobtype))
            {
                XPAmounts[jobtype] = amount;
            }
            else
            {
                XPAmounts.Add(jobtype, amount);
            }
        }

        public ulong GetRawXP(string jobtype)
        {
            if (XPAmounts.ContainsKey(jobtype))
            {
                return XPAmounts[jobtype];
            }
            else
            {
                return 0;
            }
        }

        public int GetLevel(string jobtype)
        {
            int level = 0;
            int baseXP = NPCManager.baseXP;
            int maxLevel = NPCManager.maxLevel;
            float XPMultiplier = NPCManager.XPMultiplier;

            if (XPAmounts.ContainsKey(jobtype))
            {
                ulong xp = XPAmounts[jobtype];

                if (xp > (ulong)baseXP)
                {
                    double levelMultiplier = (double)xp / (double)baseXP;
                    double levelD = Math.Log(levelMultiplier, XPMultiplier);
                    int levelI = (int)Math.Floor(levelD);

                    level = levelI;
                    if (levelI > maxLevel)
                    {
                        level = maxLevel;
                    }
                    else if (levelI < 0)
                    {
                        level = 0;
                    }
                }
                //Helpers.Utilities.WriteLog("New Colony API", XPAmounts[jobtype].ToString() + "/" + XPLevels[jobtype].ToString());
            }
            return level;
        }

        public ushort GetXPForNextLevel(int level)
        {
            int baseXP = NPCManager.baseXP;
            int maxLevel = NPCManager.maxLevel;
            float XPMultiplier = NPCManager.XPMultiplier;

            if (level + 1 > maxLevel)
            {
                level = level - 1;
            }
            ushort xp = (ushort)Math.Floor(baseXP * Math.Pow(XPMultiplier, (level + 1)));

            return xp;
        }

        public float GetCraftingMultiplier(string jobtype)
        {
            int level = GetLevel(jobtype);

            // 2% bonus per level
            return (float)(1 - (level * NPCManager.EfficiencyPerLevel));
        }

        public float GetGatherChance(string jobtype)
        {
            int level = GetLevel(jobtype);

            return (float)(1 - (level * NPCManager.GatherEfficiencyPerLevel));
        }

        public void RecalculateAllLevels(bool silent = false)
        {
            if (XPAmounts.Count > 0)
            {
                foreach (string job in XPAmounts.Keys)
                {
                    if (XPLevels.ContainsKey(job))
                    {
                        XPLevels[job] = GetLevel(job);
                    }
                    else
                    {
                        XPLevels.Add(job, GetLevel(job));
                    }

                    if (silent == false)
                    {
                        //Helpers.Utilities.WriteLog("New Colony API", "Updated NPC level in " + job + " to level " + getLevel(job), Helpers.Utilities.LogType.Info);
                    }
                }
            }
        }

        public Pipliz.JSON.JSONNode ToJSON()
        {
            Pipliz.JSON.JSONNode node = new Pipliz.JSON.JSONNode(Pipliz.JSON.NodeType.Object);

            if (XPAmounts.Count > 0)
            {
                foreach (string jobname in XPAmounts.Keys)
                {
                    node.SetAs(jobname, XPAmounts[jobname]);
                }
            }

            return node;
        }
    }
}