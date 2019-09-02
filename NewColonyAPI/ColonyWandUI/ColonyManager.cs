using Jobs;
using System.Collections.Generic;

namespace PhentrixGames.NewColonyAPI.ColonyWandUI
{
    internal static class ColonyManager
    {
        internal static void SendUI(Players.Player player)
        {
            if (player == null)
                return;
            if (player.ActiveColony == null)
                return;

            Pipliz.Collections.SortedList<string, ColonyJobData> jobinfo = GetColonyInfo(player.ActiveColony);
            NetworkUI.NetworkMenuManager.SendServerPopup(player, BuildManager(player, jobinfo));
        }

        private static NetworkUI.NetworkMenu BuildManager(Players.Player player, Pipliz.Collections.SortedList<string, ColonyJobData> jobinfo)
        {
            NetworkUI.NetworkMenu ret = NetworkStuff.BaseMenu();
            ret.LocalStorage.SetAs("header", "Colony Manager");

            List<(NetworkUI.IItem, int)> headers = new List<(NetworkUI.IItem, int)>();
            headers.Add((new NetworkUI.Items.Label("Job"), 140));
            headers.Add((new NetworkUI.Items.Label("Working"), 140));
            headers.Add((new NetworkUI.Items.Label("Available"), 140));
            ret.Items.Add(new NetworkUI.Items.HorizontalRow(headers));

            //List Jobs
            foreach (var item in jobinfo)
            {
                List<(NetworkUI.IItem, int)> items = new List<(NetworkUI.IItem, int)>();
                items.Add((new NetworkUI.Items.Label(item.Key), 140));

                items.Add((new NetworkUI.Items.Label(item.Value.Taken.ToString()), 140));
                items.Add((new NetworkUI.Items.Label(item.Value.Avaible.ToString()), 140));

                items.Add((new NetworkUI.Items.ButtonCallback("PG.Recruit." + item.Key, new NetworkUI.LabelData("Recruit", UnityEngine.Color.black, UnityEngine.TextAnchor.MiddleCenter)), 140));

                items.Add((new NetworkUI.Items.ButtonCallback("PG.Jobs." + item.Key, new NetworkUI.LabelData("NPC List", UnityEngine.Color.black, UnityEngine.TextAnchor.MiddleCenter)), 140));

                ret.LocalStorage.SetAs("PG.Recruit." + item.Key, 0);
                ret.LocalStorage.SetAs("PG.Jobs." + item.Key, 0);
                ret.Items.Add(new NetworkUI.Items.HorizontalRow(items));
            }

            return ret;
        }

        internal static Pipliz.Collections.SortedList<string, ColonyJobData> GetColonyInfo(Colony colony)
        {
            Dictionary<string, ColonyJobData> tmp = new Dictionary<string, ColonyJobData>();
            if (colony != null)
            {
                List<IJob> jobs = colony?.JobFinder?.JobsData?.OpenJobs;
                List<NPC.NPCBase> npcs = colony?.Followers;

                if (jobs != null)
                {
                    foreach (IJob job in jobs)
                    {
                        if (NPC.NPCType.NPCTypes.TryGetValue(job.NPCType, out NPC.INPCTypeSettings nPCTypeSettings))
                        {
                            if (tmp.ContainsKey(nPCTypeSettings.PrintName) == false)
                                tmp.Add(nPCTypeSettings.PrintName, new ColonyJobData());

                            tmp[nPCTypeSettings.PrintName].Avaible++;
                            tmp[nPCTypeSettings.PrintName].AvaibleJobs.Add(job);
                        }
                    }
                }

                if (npcs != null)
                {
                    foreach (NPC.NPCBase npc in npcs)
                    {
                        if (npc.Job != null)
                        {
                            if (npc.Job.IsValid)
                            {
                                if (NPC.NPCType.NPCTypes.TryGetValue(npc.Job.NPCType, out NPC.INPCTypeSettings nPCTypeSettings))
                                {
                                    if (tmp.ContainsKey(nPCTypeSettings.PrintName) == false)
                                        tmp.Add(nPCTypeSettings.PrintName, new ColonyJobData());

                                    tmp[nPCTypeSettings.PrintName].Taken++;
                                    tmp[nPCTypeSettings.PrintName].TakenJobs.Add(npc.Job);
                                }
                            }
                        }
                    }
                }
            }

            Pipliz.Collections.SortedList<string, ColonyJobData> ret = new Pipliz.Collections.SortedList<string, ColonyJobData>(tmp.Count);
            foreach (var item in tmp)
            {
                ret.Add(item.Key, item.Value);
            }
            return ret;
        }

        public static int GetCountValue(int countIndex)
        {
            //Will make dropdown later or something
            var value = "1";
            int retval = int.MaxValue;

            if (int.TryParse(value, out int count))
            {
                retval = count;
            }

            return retval;
        }
    }
}