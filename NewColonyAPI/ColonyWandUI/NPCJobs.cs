using System.Collections.Generic;

namespace PhentrixGames.NewColonyAPI.ColonyWandUI
{
    internal static class NPCJobs
    {
        internal static void SendUI(Players.Player player, string jobname)
        {
            if (player == null)
                return;
            if (player.ActiveColony == null)
                return;

            NetworkUI.NetworkMenuManager.SendServerPopup(player, BuildManager(player, jobname));
        }

        private static NetworkUI.NetworkMenu BuildManager(Players.Player player, string jobname)
        {
            NetworkUI.NetworkMenu ret = NetworkStuff.BaseMenu();
            ret.LocalStorage.SetAs("header", "Job Manager");
            List<NPC.NPCBase> npcs = GetNPCsofJob(player.ActiveColony, jobname);

            List<(NetworkUI.IItem, int)> headers = new List<(NetworkUI.IItem, int)>();
            headers.Add((new NetworkUI.Items.Label("Name"), 140));
            headers.Add((new NetworkUI.Items.Label("Age"), 140));
            headers.Add((new NetworkUI.Items.Label("Job Level"), 140));
            headers.Add((new NetworkUI.Items.Label("Action Speed"), 140));
            ret.Items.Add(new NetworkUI.Items.HorizontalRow(headers));

            foreach (var npc in npcs)
            {
                if (NPCXP.JobManager.GetJobData(npc.NPCType, out NPCXP.JobData jobData))
                {
                    NPCXP.NPCData npcData = NPCXP.NPCManager.GetNPCData(npc.ID, player.ActiveColony);
                    NPCXP.XPData xpData = npcData.XPData;
                    List<(NetworkUI.IItem, int)> items = new List<(NetworkUI.IItem, int)>();
                    items.Add((new NetworkUI.Items.Label(npcData.Name), 140));
                    items.Add((new NetworkUI.Items.Label(npcData.Age.ToString()), 140));
                    items.Add((new NetworkUI.Items.Label(xpData.GetLevel(jobname).ToString()), 140));

                    items.Add((new NetworkUI.Items.Label((jobData.cooldown * xpData.GetCraftingMultiplier(jobname)).ToString()), 140));

                    ret.Items.Add(new NetworkUI.Items.HorizontalRow(items));
                }
            }

            return ret;
        }

        private static List<NPC.NPCBase> GetNPCsofJob(Colony colony, string jobname)
        {
            List<NPC.NPCBase> ret = new List<NPC.NPCBase>();

            if (colony != null)
            {
                List<NPC.NPCBase> npcs = colony?.Followers;
                if (npcs != null)
                {
                    foreach (var npc in npcs)
                    {
                        if (npc.Job.IsValid)
                        {
                            if (npc.NPCType.ToString() == jobname)
                            {
                                ret.Add(npc);
                            }
                        }
                    }
                }
            }

            return ret;
        }
    }
}