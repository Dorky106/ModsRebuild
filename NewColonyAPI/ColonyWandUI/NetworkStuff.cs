using NetworkUI;
using System.Collections.Generic;

namespace PhentrixGames.NewColonyAPI.ColonyWandUI
{
    [ModLoader.ModManager]
    public static class NetworkStuff
    {
        private static Dictionary<string, string> menus = new Dictionary<string, string>();

        public static void AddMenuOptions(string label, string callbackid)
        {
            menus.Add(label, callbackid);
        }

        public static Dictionary<string, string> GetMenuOptions()
        {
            return menus;
        }

        public static NetworkUI.NetworkMenu BaseMenu()
        {
            NetworkUI.NetworkMenu ret = new NetworkUI.NetworkMenu();
            ret.Width = 1000;
            ret.Height = 500;
            int total = menus.Count;
            int counter = 0;
            int menubuttonwidth = 0;
            if (total >= 5)
            {
                menubuttonwidth = 193;
            }
            else if (total == 4)
            {
                menubuttonwidth = 243;
            }
            else if (total == 3)
            {
                menubuttonwidth = 326;
            }
            else if (total == 2)
            {
                menubuttonwidth = 493;
            }
            else
            {
                menubuttonwidth = 990;
            }
            List<(NetworkUI.IItem, int)> topbuttons = new List<(NetworkUI.IItem, int)>();
            foreach (var item in menus)
            {
                topbuttons.Add((new NetworkUI.Items.ButtonCallback(item.Value, new NetworkUI.LabelData(item.Key, UnityEngine.Color.black, UnityEngine.TextAnchor.MiddleCenter)), menubuttonwidth));
                ret.LocalStorage.SetAs(item.Value, 0);
                total--;
                counter++;
                if (counter == 5)
                {
                    counter = 0;
                    ret.Items.Add(new NetworkUI.Items.HorizontalRow(topbuttons));
                    topbuttons = new List<(NetworkUI.IItem, int)>();
                    if (total >= 5)
                    {
                        menubuttonwidth = 193;
                    }
                    else if (total == 4)
                    {
                        menubuttonwidth = 243;
                    }
                    else if (total == 3)
                    {
                        menubuttonwidth = 326;
                    }
                    else if (total == 2)
                    {
                        menubuttonwidth = 493;
                    }
                    else
                    {
                        menubuttonwidth = 990;
                    }
                }
            }
            ret.Items.Add(new NetworkUI.Items.HorizontalRow(topbuttons));
            ret.Items.Add(new NetworkUI.Items.Line(UnityEngine.Color.black));
            return ret;
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnPlayerPushedNetworkUIButton, NewColonyAPIEntry.Naming + "NetworkUIBotton")]
        public static void OnPlayerPushedNetworkUIButton(ButtonPressCallbackData data)
        {
            if (data.Player.ActiveColony == null)
                return;

            if (data.ButtonIdentifier.StartsWith("PG.") == false)
                return;

            Pipliz.Collections.SortedList<string, ColonyJobData> colonyinfo = ColonyManager.GetColonyInfo(data.Player.ActiveColony);

            if (data.ButtonIdentifier.Contains("PG.Colony.Management"))
            {
                ColonyManager.SendUI(data.Player);
                return;
            }
            else if (data.ButtonIdentifier.Contains("PG.Jobs."))
            {
                NPCJobs.SendUI(data.Player, data.ButtonIdentifier.Split('.')[2]);
                return;
            }
            else if (data.ButtonIdentifier.Contains("PG.Colony.Itemcount"))
            {
                Itemcount.SendUI(data.Player);
                return;
            }
            else if (data.ButtonIdentifier.Contains("PG.Recruit."))
            {
                foreach (var job in colonyinfo)
                {
                    if (data.ButtonIdentifier.Contains(job.Key))
                    {
                        int recruit = data.Storage.GetAs<int>("PG.Recruit." + job.Key);
                        int count = ColonyManager.GetCountValue(recruit);

                        if (count > job.Value.Avaible)
                            count = job.Value.Avaible;

                        for (int i = 0; i < count; i++)
                        {
                            var num = 0f;
                            data.Player.ActiveColony.HappinessData.RecruitmentCostCalculator.GetCost(data.Player.ActiveColony.HappinessData.CachedHappiness, data.Player.ActiveColony, out float foodcost);
                            if (data.Player.ActiveColony.Stockpile.TotalFood < foodcost || data.Player.ActiveColony.Stockpile.TryRemoveFood(ref num, foodcost) == false)
                            {
                                Helpers.Chat.Send(data.Player, "Colony does not have enough food!");
                                break;
                            }
                            if (data.Player.ActiveColony.CalculateBedCount() <= data.Player.ActiveColony.FollowerCount)
                            {
                                Helpers.Chat.Send(data.Player, "Colony does not have enough beds!");
                                break;
                            }
                            else
                            {
                                NPC.NPCBase newguy = new NPC.NPCBase(data.Player.ActiveColony, data.Player.ActiveColony.GetClosestBanner(new Pipliz.Vector3Int(data.Player.Position)).Position);
                                data.Player.ActiveColony.RegisterNPC(newguy);

                                NPC.NPCTracker.Add(newguy);

                                if (newguy.IsValid)
                                {
                                    newguy.TakeJob(job.Value.AvaibleJobs[i]);
                                    data.Player.ActiveColony.JobFinder.Remove(job.Value.AvaibleJobs[i]);
                                }
                            }
                        }
                        data.Player.ActiveColony.SendCommonData();
                        ColonyManager.SendUI(data.Player);
                    }
                }
                return;
            }
        }
    }
}