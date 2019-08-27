using PhentrixGames.NewColonyAPI.Configuration;
using Pipliz;
using Shared;
using System;
using System.Collections.Generic;
using System.Threading;

namespace PhentrixGames.NewColonyAPI.Fluids
{
    [ModLoader.ModManager]
    public static class FluidManager
    {
        private static Thread _FluidsThread = new Thread(FluidActions);
        public static Pipliz.Collections.BinaryHeap<long, Action> _actions = new Pipliz.Collections.BinaryHeap<long, Action>(8);
        public static AutoResetEvent _SomeAction = new AutoResetEvent(false);

        public static FluidInfo[] _fluids = new FluidInfo[(int)EFluids.MAX];

        public static string MODPATH;

        public const int W_MAX_DISTANCE = 8;
        public const int W_MIN_DISTANCE = 2;
        public const int W_DEFAULT_DISTANCE = 8;

        public const long W_MAX_SPEED = 500;
        public const long W_MIN_SPEED = 200;
        public const long W_DEFAULT_SPEED = 300;

        public const int L_MAX_DISTANCE = 7;
        public const int L_MIN_DISTANCE = 2;
        public const int L_DEFAULT_DISTANCE = 3;

        public const long L_MAX_SPEED = 500;
        public const long L_MIN_SPEED = 200;
        public const long L_DEFAULT_SPEED = 300;

        private static Vector3Int[] adjacents = { Vector3Int.left, Vector3Int.forward, Vector3Int.right, Vector3Int.back };

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterWorldLoad, NewColonyAPIEntry.Naming + "FluidManager")]
        public static void Init()
        {
            FluidInfo Water = new FluidInfo();
            FluidInfo Lava = new FluidInfo();

            Water.source = ItemTypes.IndexLookup.GetIndex("GreatWater");
            Water.fake = ItemTypes.IndexLookup.GetIndex("GreatWaterFake");
            Water.bucket = ItemTypes.IndexLookup.GetIndex("bucketwater");

            //Lava.source = ItemTypes.IndexLookup.GetIndex("Khanx.SimpleFluids.Lava");
            //Lava.fake = ItemTypes.IndexLookup.GetIndex("Khanx.SimpleFluids.Fake.Lava");
            //Lava.bucket = ItemTypes.IndexLookup.GetIndex("Khanx.SimpleFluids.LavaBucket");

            int w_spreadDistance = ConfigManager.GetConfigIntOrDefault(NewColonyAPIEntry.ModName, "fluids.water.spreaddistance", 8);
            if (w_spreadDistance > W_MAX_DISTANCE || w_spreadDistance < W_MIN_DISTANCE)
            {
                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, string.Format("Water spreaddistance must be between {0} and {1}", W_MIN_DISTANCE, W_MAX_DISTANCE), Helpers.Logging.LogType.Loading);
                w_spreadDistance = W_DEFAULT_DISTANCE;
            }
            Water.distance = w_spreadDistance;
            long w_spreadSpeed = ConfigManager.GetConfigIntOrDefault(NewColonyAPIEntry.ModName, "fluids.water.spreadspeed", 350);
            if (w_spreadSpeed > W_MAX_SPEED || w_spreadSpeed < W_MIN_SPEED)
            {
                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, string.Format("Water spreadspeed must be between {0} and {1}", W_MIN_SPEED, W_MAX_SPEED), Helpers.Logging.LogType.Loading);
                w_spreadSpeed = W_DEFAULT_SPEED;
            }
            Water.time = w_spreadSpeed;

            int l_spreadDistance = ConfigManager.GetConfigIntOrDefault(NewColonyAPIEntry.ModName, "fluids.lava.spreaddistance", 8);
            if (l_spreadDistance > L_MAX_DISTANCE || l_spreadDistance < L_MIN_DISTANCE)
            {
                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, string.Format("Lava spreaddistance must be between {0} and {1}", L_MIN_DISTANCE, L_MAX_DISTANCE), Helpers.Logging.LogType.Loading);
                l_spreadDistance = L_DEFAULT_DISTANCE;
            }
            Lava.distance = l_spreadDistance;
            long l_spreadSpeed = ConfigManager.GetConfigIntOrDefault(NewColonyAPIEntry.ModName, "fluids.lava.spreadspeed", 350);
            if (l_spreadSpeed > L_MAX_SPEED || l_spreadSpeed < L_MIN_SPEED)
            {
                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, string.Format("Lava spreadspeed must be between {0} and {1}", L_MIN_SPEED, L_MAX_SPEED), Helpers.Logging.LogType.Loading);
                w_spreadSpeed = L_DEFAULT_SPEED;
            }
            Lava.time = l_spreadSpeed;

            _fluids[(int)EFluids.Water] = Water;
            _fluids[(int)EFluids.Lava] = Lava;

            _FluidsThread.IsBackground = true;
            _FluidsThread.Start();
        }

        public static void FluidActions()
        {
            while (true)
            {
                try
                {
                    while (_actions.Count == 0)
                        _SomeAction.WaitOne();

                    long timeToSleep = _actions.PeekMinKey() - Time.MillisecondsSinceStart;

                    if (timeToSleep > 0)
                    {
                        Thread.Sleep((int)timeToSleep);
                    }

                    _actions.ExtractValueMin()();
                }
                catch (Exception e)
                {
                    Log.Write(e.Message);
                }
            }
        }

        public static void Spread(Vector3Int position, EFluids fluid, int distance = int.MinValue, bool start = true)
        {
            //Log.Write(string.Format("<color=blue>Spread {0}</color>", position));

            FluidInfo info = _fluids[(int)fluid];

            if (distance == int.MinValue)
                distance = info.distance;

            if (distance <= 0)
                return;

            if (start)
            {
                ThreadManager.InvokeOnMainThread(() =>
                {
                    if (World.TryGetTypeAt(position, out ushort posType) && (posType == BlockTypes.BuiltinBlocks.Types.air.ItemIndex || posType == info.fake))
                        ServerManager.TryChangeBlock(position, info.source);
                });
            }
            else
            {
                ThreadManager.InvokeOnMainThread(() =>
                {
                    if (World.TryGetTypeAt(position, out ushort posType) && (posType == BlockTypes.BuiltinBlocks.Types.air.ItemIndex))
                        ServerManager.TryChangeBlock(position, info.fake);
                });
            }

            var down = position + Vector3Int.down;

            if (!World.TryGetTypeAt(down, out ushort typeDown))
                return;

            //If DOWN is source -> IGNORE
            if (typeDown == info.source || typeDown == BlockTypes.BuiltinBlocks.Types.water.ItemIndex)
                return;

            //If down is air or fake.fluid -> SPREAD DOWN
            if (typeDown == BlockTypes.BuiltinBlocks.Types.air.ItemIndex || typeDown == info.fake)
            {
                _actions.Add(Time.MillisecondsSinceStart + info.time, delegate ()
                {
                    Spread(down, fluid);
                });

                _SomeAction.Set();
                return;
            }

            foreach (var adjacent in adjacents)
            {
                var adj = position + adjacent;

                if (!World.TryGetTypeAt(adj, out ushort typeAdj))
                    continue;

                if (typeAdj == BlockTypes.BuiltinBlocks.Types.air.ItemIndex || typeAdj == info.fake)
                {
                    var adjDown = adj + Vector3Int.down;

                    if (!World.TryGetTypeAt(adjDown, out ushort typeAdjD))
                        continue;

                    if (typeAdjD == info.source || typeAdjD == BlockTypes.BuiltinBlocks.Types.water.ItemIndex) // Source
                        continue;

                    //Continue spreading down
                    if (typeAdjD == BlockTypes.BuiltinBlocks.Types.air.ItemIndex)
                    {
                        _actions.Add(Time.MillisecondsSinceStart + info.time, delegate ()
                        {
                            Spread(adjDown, fluid);
                        });

                        _SomeAction.Set();
                    }
                    else //Spread Side
                    {
                        _actions.Add(Time.MillisecondsSinceStart + info.time, delegate ()
                        {
                            Spread(adj, fluid, distance - 1, false);
                        });

                        _SomeAction.Set();
                    }
                }
            }
        }

        public static void Remove(Vector3Int position, EFluids fluid, ushort newType = ushort.MaxValue)
        {
            //Log.Write(string.Format("<color=blue>Remove {0}</color>", position));

            FluidInfo info = _fluids[(int)fluid];

            if (!World.TryGetTypeAt(position, out ushort posToRemove) && (posToRemove != info.source && posToRemove != info.fake))
                return;

            ThreadManager.InvokeOnMainThread(() =>
            {
                if (newType == ushort.MaxValue)
                    ServerManager.TryChangeBlock(position, BlockTypes.BuiltinBlocks.Types.air);
                else
                    ServerManager.TryChangeBlock(position, newType);
            });

            var down = position + Vector3Int.down;

            if (!World.TryGetTypeAt(down, out ushort typeDown))
                return;

            //If DOWN is source
            if (typeDown == info.source)
            {
                _actions.Add(Time.MillisecondsSinceStart + info.time, delegate ()
                {
                    Remove(down, fluid);
                });

                _SomeAction.Set();
                return;
            }

            foreach (var adjacent in adjacents)
            {
                var adj = position + adjacent;

                if (!World.TryGetTypeAt(adj, out ushort typeAdj))
                    continue;

                if (typeAdj == info.fake)
                {
                    _actions.Add(Time.MillisecondsSinceStart + info.time, delegate ()
                    {
                        TryRemove(adj, fluid, info.distance - 1);
                    });

                    _SomeAction.Set();
                }
                else if (typeAdj == BlockTypes.BuiltinBlocks.Types.air.ItemIndex)
                {
                    var adjD = adj + Vector3Int.down;

                    if (!World.TryGetTypeAt(adjD, out ushort typeAdjD))
                        continue;

                    if (typeAdjD == info.source)
                    {
                        _actions.Add(Time.MillisecondsSinceStart + info.time, delegate ()
                        {
                            Remove(adjD, fluid);
                        });

                        _SomeAction.Set();
                    }
                }
            }
        }

        public static void TryRemove(Vector3Int position, EFluids fluid, int distance = int.MinValue)
        {
            //Log.Write(string.Format("<color=blue>TryRemove {0}</color>", position));

            FluidInfo info = _fluids[(int)fluid];

            if (!World.TryGetTypeAt(position, out ushort typeToRemove) && (typeToRemove != info.source && typeToRemove != info.fake))
                return;

            if (distance == int.MinValue)
                distance = info.distance;

            if (distance < 0)
                return;

            if (!World.TryGetTypeAt(position, out ushort type))
                return;

            if (type != info.fake)
                return;

            if (ClosestSource(position, fluid) == Vector3Int.maximum)
            {
                ThreadManager.InvokeOnMainThread(() =>
                {
                    if (World.TryGetTypeAt(position, out ushort posToRemove) && (posToRemove == info.fake))
                        ServerManager.TryChangeBlock(position, BlockTypes.BuiltinBlocks.Types.air);
                });
            }

            var down = position + Vector3Int.down;

            if (!World.TryGetTypeAt(down, out ushort typeDown))
                return;

            if (typeDown == info.source)
            {
                _actions.Add(Time.MillisecondsSinceStart + info.time, delegate ()
                {
                    Remove(down, fluid);
                });

                _SomeAction.Set();
                return;
            }

            foreach (var adjacent in adjacents)
            {
                var adj = position + adjacent;

                if (!World.TryGetTypeAt(adj, out ushort typeAdj))
                    continue;

                if (typeAdj == info.fake)
                {
                    _actions.Add(Time.MillisecondsSinceStart + info.time, delegate ()
                    {
                        TryRemove(adj, fluid, distance - 1);
                    });

                    _SomeAction.Set();
                }
                else if (typeAdj == BlockTypes.BuiltinBlocks.Types.air.ItemIndex)
                {
                    var adjD = adj + Vector3Int.down;

                    if (!World.TryGetTypeAt(adjD, out ushort typeAdjD))
                        continue;

                    if (typeAdjD == info.source)
                    {
                        _actions.Add(Time.MillisecondsSinceStart + info.time, delegate ()
                        {
                            Remove(adjD, fluid);
                        });

                        _SomeAction.Set();
                    }
                }
            }
        }

        public static Vector3Int ClosestSource(Vector3Int position, EFluids fluid)
        {
            FluidInfo info = _fluids[(int)fluid];

            LinkedList<Tuple<Vector3Int, int>> toVisit = new LinkedList<Tuple<Vector3Int, int>>();

            toVisit.AddLast(new Tuple<Vector3Int, int>(position, 0));

            List<Vector3Int> alreadyVisited = new List<Vector3Int>();

            while (toVisit.Count > 0)
            {
                var node = toVisit.First.Value;
                toVisit.RemoveFirst();

                if (alreadyVisited.Contains(node.Item1))
                    continue;

                alreadyVisited.Add(node.Item1);

                if (node.Item2 == info.distance)
                    continue;

                foreach (var adjacent in adjacents)
                {
                    var adj = node.Item1 + adjacent;

                    if (!World.TryGetTypeAt(adj, out ushort typeadj))
                        continue;

                    if (typeadj == info.source)
                        return adj;

                    if (typeadj == info.fake)
                        if (!alreadyVisited.Contains(adj))
                            toVisit.AddLast(new Tuple<Vector3Int, int>(adj, node.Item2 + 1));
                }
            }

            return Vector3Int.maximum;
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnPlayerClicked, NewColonyAPIEntry.Naming + "OnFluidClick")]
        public static void OnPlayerClicked(Players.Player player, PlayerClickedData boxedData)
        {
            if (player == null)
                return;

            if (boxedData.ClickType == PlayerClickedData.EClickType.Right)
            {
                if (boxedData.HitType == PlayerClickedData.EHitType.Block)
                {
                    if (boxedData.GetVoxelHit().TypeHit != BlockTypes.BuiltinBlocks.Types.air.ItemIndex || boxedData.GetVoxelHit().TypeHit != BlockTypes.BuiltinBlocks.Types.water.ItemIndex)
                    {
                        if (boxedData.TypeSelected == ItemTypes.IndexLookup.GetIndex("bucketempty"))
                        {
                            foreach (var item in _fluids)
                            {
                                if (boxedData.GetVoxelHit().TypeHit == item.source)
                                {
                                    FluidManager.Remove(boxedData.GetVoxelHit().BlockHit, EFluids.Water);
                                    if (player.Inventory.TryRemove(boxedData.TypeSelected))
                                    {
                                        if (player.Inventory.TryAdd(ItemTypes.IndexLookup.GetIndex("bucketwater")) == false)
                                        {
                                            if (player.ActiveColony != null)
                                            {
                                                player.ActiveColony.Stockpile.Add(ItemTypes.IndexLookup.GetIndex("bucketwater"));
                                            }
                                            else
                                            {
                                                Helpers.Chat.Send(player, "Inventory is full and no active colony, deleting item!");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (boxedData.TypeSelected == ItemTypes.IndexLookup.GetIndex("bucketwater"))
                        {
                            Vector3Int newPos = boxedData.GetVoxelHit().BlockHit;
                            switch (boxedData.GetVoxelHit().SideHit)
                            {
                                case VoxelSide.xMin:
                                    newPos = newPos.Add(-1, 0, 0);
                                    break;

                                case VoxelSide.xPlus:
                                    newPos = newPos.Add(1, 0, 0);
                                    break;

                                case VoxelSide.yMin:
                                    newPos = newPos.Add(0, -1, 0);
                                    break;

                                case VoxelSide.yPlus:
                                    newPos = newPos.Add(0, 1, 0);
                                    break;

                                case VoxelSide.zMin:
                                    newPos = newPos.Add(0, 0, -1);
                                    break;

                                case VoxelSide.zPlus:
                                    newPos = newPos.Add(0, 0, 1);
                                    break;
                            }
                            if (World.TryGetTypeAt(newPos, out ushort actualType) && actualType == BlockTypes.BuiltinBlocks.Types.air.ItemIndex)
                            {
                                FluidManager.Spread(newPos, EFluids.Water);

                                player.Inventory.TryRemove(ItemTypes.IndexLookup.GetIndex("bucketwater"));
                                if (!player.Inventory.TryAdd(ItemTypes.IndexLookup.GetIndex("bucketempty")))
                                {
                                    if (player.ActiveColony != null)
                                    {
                                        player.ActiveColony.Stockpile.Add(ItemTypes.IndexLookup.GetIndex("bucketempty"));
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}