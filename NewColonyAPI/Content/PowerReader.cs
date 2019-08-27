using Shared;
using System;
using System.Collections.Generic;

namespace PhentrixGames.NewColonyAPI.Content
{
    [Recipe.RecipeManager.NCAPIRecipe]
    public class PowerReaderRecipe : Recipe.BaseRecipe
    {
        public PowerReaderRecipe() : base("PowerReaderRecipe", null, true)
        {
            this.Requirements = new System.Collections.Generic.List<InventoryItem>
            {
                new InventoryItem("planks", 10)
            };
            this.Result = new System.Collections.Generic.List<InventoryItem>
            {
                new InventoryItem("Power Reader")
            };
        }
    }

    [Power.PowerManager.NCAPIPowerType]
    public class PowerReader : Types.BaseType
    {
        public PowerReader() : base("Power Reader", false)
        {
            this.IsPlaceable = false;
            this.Icon = Helpers.Utilities.MultiCombine(NewColonyAPIEntry.ModIconDirectory, "powerreader.png");
        }
    }

    [ModLoader.ModManager]
    public static class PowerReaderClick
    {
        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnPlayerClicked, NewColonyAPIEntry.Naming + "PowerReaderClick")]
        public static void OnPlayerClicked(Players.Player player, PlayerClickedData clickedData)
        {
            if (Power.PowerManager.IsEnabled())
            {
                if (clickedData.ClickType == PlayerClickedData.EClickType.Left)
                {
                    if (clickedData.TypeSelected == ItemTypes.IndexLookup.GetIndex("Power Reader"))
                    {
                        if (clickedData.HitType == PlayerClickedData.EHitType.Block)
                        {
                            if (ItemTypes.IndexLookup.GetName(clickedData.GetVoxelHit().TypeHit).Contains("PowerLine"))
                            {
                                return;
                            }
                            else if (Power.PowerManager.IsPowerBlock(ItemTypes.IndexLookup.GetName(clickedData.GetVoxelHit().TypeHit)))
                            {
                                int menuwidth = 200;
                                NetworkUI.NetworkMenu menu = new NetworkUI.NetworkMenu();
                                menu.LocalStorage.SetAs("header", ItemTypes.IndexLookup.GetName(clickedData.GetVoxelHit().TypeHit));
                                menu.Width = menuwidth * 3;

                                switch (Power.PowerManager.PowerType(ItemTypes.IndexLookup.GetName(clickedData.GetVoxelHit().TypeHit)))
                                {
                                    case "Generator":
                                        Power.PowerManager.GetPowerObject(ItemTypes.IndexLookup.GetName(clickedData.GetVoxelHit().TypeHit), out Power.PowerObject pogen);
                                        Power.Generator gen = (Power.Generator)pogen as Power.Generator;
                                        List<ValueTuple<NetworkUI.IItem, int>> items2 = new List<(NetworkUI.IItem, int)>
                                    {
                                        ValueTuple.Create<NetworkUI.IItem, int>(new NetworkUI.Items.Label("Generates:"), menuwidth),
                                        ValueTuple.Create<NetworkUI.IItem, int>(new NetworkUI.Items.Label(gen.Generates.ToString()), 140)
                                    };
                                        menu.Items.Add(new NetworkUI.Items.HorizontalRow(items2));
                                        break;

                                    case "Machine":
                                        Power.PowerManager.GetPowerObject(ItemTypes.IndexLookup.GetName(clickedData.GetVoxelHit().TypeHit), out Power.PowerObject pomach);
                                        Power.Machine mac = (Power.Machine)pomach as Power.Machine;
                                        List<ValueTuple<NetworkUI.IItem, int>> items3 = new List<(NetworkUI.IItem, int)>
                                    {
                                        ValueTuple.Create<NetworkUI.IItem, int>(new NetworkUI.Items.Label("Uses:"), menuwidth),
                                        ValueTuple.Create<NetworkUI.IItem, int>(new NetworkUI.Items.Label(mac.PowerUsage.ToString()), 140)
                                    };
                                        menu.Items.Add(new NetworkUI.Items.HorizontalRow(items3));
                                        break;
                                }
                                List<ValueTuple<NetworkUI.IItem, int>> items = new List<(NetworkUI.IItem, int)>
                            {
                                ValueTuple.Create<NetworkUI.IItem, int>(new NetworkUI.Items.Label("Power:"), menuwidth + 80)
                            };
                                Power.PowerManager.GetPower(clickedData.GetVoxelHit().BlockHit, out int power);
                                Power.PowerManager.GetMaxPower(clickedData.GetVoxelHit().BlockHit, out int maxpower);
                                items.Add(ValueTuple.Create<NetworkUI.IItem, int>(new NetworkUI.Items.Label(power.ToString()), 140));
                                items.Add(ValueTuple.Create<NetworkUI.IItem, int>(new NetworkUI.Items.Label(":"), 20));
                                items.Add(ValueTuple.Create<NetworkUI.IItem, int>(new NetworkUI.Items.Label(maxpower.ToString()), 140));
                                menu.Items.Add(new NetworkUI.Items.HorizontalRow(items));
                                NetworkUI.NetworkMenuManager.SendServerPopup(player, menu);
                            }
                        }
                    }
                }
            }
        }
    }
}