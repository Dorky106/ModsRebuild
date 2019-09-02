using System.Collections.Generic;

namespace PhentrixGames.NewColonyAPI.ColonyWandUI
{
    internal static class Itemcount
    {
        internal static void SendUI(Players.Player player)
        {
            if (player == null)
                return;
            if (player.ActiveColony == null)
                return;

            NetworkUI.NetworkMenuManager.SendServerPopup(player, BuildMenu(player));
        }

        private static NetworkUI.NetworkMenu BuildMenu(Players.Player player)
        {
            NetworkUI.NetworkMenu ret = NetworkStuff.BaseMenu();
            ret.LocalStorage.SetAs("header", "Resource Manager");

            List<(NetworkUI.IItem, int)> headers = new List<(NetworkUI.IItem, int)>();
            headers.Add((new NetworkUI.Items.Label("Item Name"), 200));
            headers.Add((new NetworkUI.Items.Label("Today"), 200));
            headers.Add((new NetworkUI.Items.Label("Yesterday"), 200));
            headers.Add((new NetworkUI.Items.Label("Two Days Ago"), 200));
            headers.Add((new NetworkUI.Items.Label("Average"), 200));
            ret.Items.Add(new NetworkUI.Items.HorizontalRow(headers));

            Stockpile.OldStockpiles stockpiles = Stockpile.StockpileManager.GetOldStockpiles(player.ActiveColony.ColonyID);
            foreach (var item in player.ActiveColony.Stockpile.Items)
            {
                if (stockpiles.today.ContainsKey(item.Key) || stockpiles.yesterday.ContainsKey(item.Key) || stockpiles.twodaysago.ContainsKey(item.Key))
                {
                    List<(NetworkUI.IItem, int)> items = new List<(NetworkUI.IItem, int)>();
                    items.Add((new NetworkUI.Items.Label(ItemTypes.IndexLookup.GetName(item.Key)), 200));
                    int avg = 0;
                    if (stockpiles.today.ContainsKey(item.Key))
                    {
                        avg += stockpiles.today[item.Key];
                        items.Add((new NetworkUI.Items.Label(stockpiles.today[item.Key].ToString()), 200));
                    }
                    else
                    {
                        items.Add((new NetworkUI.Items.Label("NA"), 200));
                    }
                    if (stockpiles.yesterday.ContainsKey(item.Key))
                    {
                        avg += stockpiles.yesterday[item.Key];
                        items.Add((new NetworkUI.Items.Label(stockpiles.yesterday[item.Key].ToString()), 200));
                    }
                    else
                    {
                        items.Add((new NetworkUI.Items.Label("NA"), 200));
                    }
                    if (stockpiles.twodaysago.ContainsKey(item.Key))
                    {
                        avg += stockpiles.twodaysago[item.Key];
                        items.Add((new NetworkUI.Items.Label(stockpiles.twodaysago[item.Key].ToString()), 200));
                    }
                    else
                    {
                        items.Add((new NetworkUI.Items.Label("NA"), 200));
                    }
                    avg = avg / 3;
                    items.Add((new NetworkUI.Items.Label(avg.ToString()), 200));
                    ret.Items.Add(new NetworkUI.Items.HorizontalRow(items));
                }
            }
            return ret;
        }
    }
}