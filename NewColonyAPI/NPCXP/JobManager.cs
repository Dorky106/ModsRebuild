using Pipliz.JSON;
using System.Collections.Generic;
using System.IO;

namespace PhentrixGames.NewColonyAPI.NPCXP
{
    public static class JobManager
    {
        private static Dictionary<string, JobData> jobinfo = new Dictionary<string, JobData>();

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterModsLoaded, NewColonyAPIEntry.Naming + "JobManager")]
        [ModLoader.ModCallbackProvidesFor(NewColonyAPIEntry.Naming + "Dependencies")]
        internal static void Initialize()
        {
            if (File.Exists(NewColonyAPIEntry.ModFolder + "..\\..\\..\\..\\npcTypes.json"))
            {
                JSON.Deserialize(NewColonyAPIEntry.ModFolder + "..\\..\\..\\..\\npcTypes.json", out JSONNode npcTypesNode, true);

                if (File.Exists(NewColonyAPIEntry.ModFolder + "..\\..\\..\\..\\jobblocks.json"))
                {
                    JSON.Deserialize(NewColonyAPIEntry.ModFolder + "..\\..\\..\\..\\jobblocks.json", out JSONNode node, true);
                    {
                        foreach (JSONNode current in node.LoopArray())
                        {
                            string jobtype = current.GetAs<string>("jobType");
                            string currentnpctype;
                            float cooldown;

                            string tmp = "";
                            string tmptwo = "";
                            switch (jobtype)
                            {
                                case "craftingblock":
                                case "craftingblocknearwater":
                                case "craftingblockrotated":
                                case "craftingblockrotatedlit":
                                    tmp = current.GetAs<string>("npcType");
                                    cooldown = current.GetAsOrDefault("cooldown", 5f);
                                    foreach (JSONNode currenttwo in npcTypesNode.LoopArray())
                                    {
                                        tmptwo = currenttwo.GetAs<string>("keyName");
                                        if (tmp == tmptwo)
                                        {
                                            currentnpctype = currenttwo.GetAs<string>("printName");
                                            jobinfo.Add(currentnpctype, new JobData(jobtype, cooldown));
                                            break;
                                        }
                                    }
                                    break;

                                case "guard":
                                    tmp = current.GetAs<string>("npcType");
                                    cooldown = current.GetAsOrDefault("cooldownShot", 5f);
                                    foreach (JSONNode currenttwo in npcTypesNode.LoopArray())
                                    {
                                        tmptwo = currenttwo.GetAs<string>("keyName");
                                        if (tmp == tmptwo)
                                        {
                                            currentnpctype = currenttwo.GetAs<string>("printName");
                                            jobinfo.Add(currentnpctype, new JobData(jobtype, cooldown));
                                            break;
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                }
                if (File.Exists(NewColonyAPIEntry.ModFolder + "..\\..\\..\\..\\areajobs.json"))
                {
                    JSON.Deserialize(NewColonyAPIEntry.ModFolder + "..\\..\\..\\..\\areajobs.json", out JSONNode node, true);
                    {
                        foreach (JSONNode current in node.LoopArray())
                        {
                            string currentnpctype;

                            string tmptwo = "";
                            if (current.TryGetAs<string>("npcType", out string tmp))
                            {
                                foreach (JSONNode currenttwo in npcTypesNode.LoopArray())
                                {
                                    tmptwo = currenttwo.GetAs<string>("keyName");
                                    if (tmptwo.Contains("worker") || tmptwo.Contains("monster"))
                                        continue;
                                    if (tmp == tmptwo)
                                    {
                                        if (current.TryGetAs<float>("cooldown", out float cooldown))
                                        {
                                            currentnpctype = currenttwo.GetAs<string>("printName");
                                            jobinfo.Add(currentnpctype, new JobData("areajob", cooldown));
                                            break;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Could not get npcType from areajobs.json", Helpers.Logging.LogType.Issue, true);
                            }
                        }
                    }
                }
                else
                {
                    Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Areajobs.json does not exists!", Helpers.Logging.LogType.Issue, true);
                }
            }
        }

        public static bool GetJobData(NPC.NPCType npctype, out JobData jobData)
        {
            jobData = null;
            if (jobinfo.ContainsKey(npctype.ToString()))
            {
                jobData = jobinfo[npctype.ToString()];
                return true;
            }

            return false;
        }

        public static bool GetJobData(string jobname, out JobData jobData)
        {
            jobData = null;

            if (jobinfo.ContainsKey(jobname))
            {
                jobData = jobinfo[jobname];
                return true;
            }

            return false;
        }
    }
}