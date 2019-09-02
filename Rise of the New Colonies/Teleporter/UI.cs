using NetworkUI;
using Pipliz;
using Pipliz.JSON;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PhentrixGames.RiseoftheNewColonies.Teleporter
{
    [ModLoader.ModManager]
    public static class UI
    {
        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnPlayerClicked, Entry.Naming + "OnPlayerClicked")]
        public static void OnPlayerClicked(Players.Player player, PlayerClickedData boxedData)
        {
            if (boxedData.ClickType == PlayerClickedData.EClickType.Right)
            {
                if (boxedData.HitType == PlayerClickedData.EHitType.Block)
                {
                    string itemname = ItemTypes.IndexLookup.GetName(boxedData.GetVoxelHit().TypeHit);
                    if (itemname.Contains("Geo Dasher"))
                    {
                        NetworkUI.NetworkMenu menu = new NetworkUI.NetworkMenu();
                        menu.LocalStorage.SetAs("header", "Geo Dasher");
                        menu.Width = 600;
                        menu.Height = 400;

                        List<ValueTuple<NetworkUI.IItem, int>> items = new List<ValueTuple<IItem, int>>
                        {
                            ValueTuple.Create<NetworkUI.IItem, int>(new NetworkUI.Items.InputField("teleporterID"), 200),
                            (new NetworkUI.Items.ButtonCallback("PG.RotNC.Teleporter.SetKey", new NetworkUI.LabelData("Set Teleporter Key", UnityEngine.Color.black, UnityEngine.TextAnchor.MiddleCenter)), 200),
                            (new NetworkUI.Items.DropDown("Availability", "PG.RotNC.Teleporter.Availability", new List<string>() { "public", "private", "spawn" }), 200)
                        };
                        menu.Items.Add(new NetworkUI.Items.HorizontalRow(items));
                        menu.LocalStorage.SetAs("PG.RotNC.Teleporter.SetKey", 0);
                        menu.LocalStorage.SetAs("PG.RotNC.Teleporter.Availability", 0);

                        menu.Items.Add(new NetworkUI.Items.Line(UnityEngine.Color.black));

                        items = new List<ValueTuple<IItem, int>>
                        {
                            ValueTuple.Create<NetworkUI.IItem, int>(new NetworkUI.Items.InputField("gototeleporter"), 200),
                            (new NetworkUI.Items.ButtonCallback("PG.RotNC.Teleporter.GoToKey", new NetworkUI.LabelData("Go To Key", UnityEngine.Color.black, UnityEngine.TextAnchor.MiddleCenter)), 200)
                        };
                        menu.Items.Add(new NetworkUI.Items.HorizontalRow(items));
                        menu.LocalStorage.SetAs("PG.RotNC.Teleporter.GoToKey", 0);

                        menu.Items.Add(new NetworkUI.Items.Line(UnityEngine.Color.black));

                        foreach (var colony in player.Colonies)
                        {
                            if (TeleporterManager.GetKey(colony.ColonyID, out string output))
                            {
                                items = new List<ValueTuple<IItem, int>>
                                {
                                    ValueTuple.Create<NetworkUI.IItem, int>(new NetworkUI.Items.Label(colony.Name), 200),
                                    ValueTuple.Create<NetworkUI.IItem, int>(new NetworkUI.Items.Label(output), 200)
                                };
                                menu.Items.Add(new NetworkUI.Items.HorizontalRow(items));
                            }
                        }

                        if (itemname.Contains("x-"))
                        {
                            Vector3Int pos = boxedData.GetVoxelHit().BlockHit.Add(-1, 0, 0);
                            menu.LocalStorage.SetAs("location", NewColonyAPI.Helpers.Utilities.Vector3IntToNode(pos));
                        }
                        if (itemname.Contains("x+"))
                        {
                            Vector3Int pos = boxedData.GetVoxelHit().BlockHit.Add(1, 0, 0);
                            menu.LocalStorage.SetAs("location", NewColonyAPI.Helpers.Utilities.Vector3IntToNode(pos));
                        }
                        if (itemname.Contains("z-"))
                        {
                            Vector3Int pos = boxedData.GetVoxelHit().BlockHit.Add(0, 0, -1);
                            menu.LocalStorage.SetAs("location", NewColonyAPI.Helpers.Utilities.Vector3IntToNode(pos));
                        }
                        if (itemname.Contains("z+"))
                        {
                            Vector3Int pos = boxedData.GetVoxelHit().BlockHit.Add(0, 0, 1);
                            menu.LocalStorage.SetAs("location", NewColonyAPI.Helpers.Utilities.Vector3IntToNode(pos));
                        }
                        NetworkUI.NetworkMenuManager.SendServerPopup(player, menu);
                        return;
                    }
                }
            }

            if (boxedData.ClickType == PlayerClickedData.EClickType.Left)
            {
                if (boxedData.TypeSelected == ItemTypes.IndexLookup.GetIndex("Recall Device"))
                {
                    TeleporterManager.TeleportBack(player);
                }

                /*
				if (Classes.Transportation.Train.TrainTypes(boxedData.TypeSelected))
				{
					boxedData.ConsumedType = PlayerClickedData.EConsumedType.UsedAsTool;
					Classes.Transportation.Train.SpawnTrain(boxedData.GetExactHitPositionWorld());
					return;
				}
				*/
                return;
            }
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnPlayerPushedNetworkUIButton, Entry.Naming + "NetworkUIBotton")]
        public static void OnPlayerPushedNetworkUIButton(ButtonPressCallbackData data)
        {
            if (data.ButtonIdentifier == "PG.RotNC.Teleporter.GoToKey")
            {
                if (data.Storage.TryGetAs("gototeleporter", out string GoToID))
                {
                    TeleporterManager.TeleportTo(data.Player, GoToID);
                    return;
                }
            }

            if (data.Player.ActiveColony == null)
                return;

            if (data.ButtonIdentifier == "PG.RotNC.Teleporter.SetKey")
            {
                if (data.Storage.TryGetAs("teleporterID", out string teleportID))
                {
                    if (data.Storage.TryGetAs<JSONNode>("location", out JSONNode pos))
                    {
                        if (data.Player.ActiveColony.Owners.Contains(data.Player))
                        {
                            if (teleportID.Contains("spawn"))
                            {
                                if (PermissionsManager.HasPermission(data.Player, "antigrief.permission"))
                                {
                                    if (TeleporterManager.SetKey(data.Player.ActiveColony.ColonyID, teleportID, NewColonyAPI.Helpers.Utilities.NodeToVector3Int(pos)))
                                    {
                                        NewColonyAPI.Helpers.Chat.Send(data.Player, "Key Set!, " + pos.ToString());
                                    }
                                    else
                                    {
                                        NewColonyAPI.Helpers.Chat.Send(data.Player, "Key Already in use or invalid!  Must be 6 characters in length.");
                                    }
                                }
                                else
                                {
                                    NewColonyAPI.Helpers.Chat.Send(data.Player, "Don't have perms to use the word 'spawn' in teleporter key!");
                                }
                            }
                            else if (TeleporterManager.SetKey(data.Player.ActiveColony.ColonyID, teleportID, NewColonyAPI.Helpers.Utilities.NodeToVector3Int(pos)))
                            {
                                NewColonyAPI.Helpers.Chat.Send(data.Player, "Key Set!, " + pos.ToString());
                            }
                            else
                            {
                                NewColonyAPI.Helpers.Chat.Send(data.Player, "Key Already in use or invalid!  Must be 6 characters in length.");
                            }
                        }
                    }
                    else
                    {
                        NewColonyAPI.Helpers.Chat.Send(data.Player, "Unable to obtain location");
                    }
                }
                else
                {
                    NewColonyAPI.Helpers.Chat.Send(data.Player, "Unable to obtain teleporterID");
                }
            }
        }
    }
}