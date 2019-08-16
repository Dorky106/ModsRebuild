using PhentrixGames.NewColonyAPI.Configuration;
using Pipliz;
using UnityEngine;

namespace PhentrixGames.NewColonyAPI.AntiGrief
{
    [ModLoader.ModManager]
    internal class AntiGriefManager
    {
        private static string ultimatepermission = "debug";
        private static string permission = "admin";
        private static bool antigrief = false;
        private static int bannerbonusrange = 0;
        private static bool spawnprotection = false;
        private static int spawnprotectionrange = 0;
        private static Pipliz.Vector3Int spawnlocation = new Pipliz.Vector3Int();

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterWorldLoad, NewColonyAPIEntry.Naming + "SetupAntiGriefing")]
        public static void Init()
        {
            if (ConfigManager.GetConfigBooleanOrDefault(NewColonyAPIEntry.ModName, "antigrief.enabled", false) == true)
            {
                antigrief = true;
                ultimatepermission = ConfigManager.GetConfigStringOrDefault(NewColonyAPIEntry.ModName, "antigrief.ultimatepermission", "debug");
                permission = ConfigManager.GetConfigStringOrDefault(NewColonyAPIEntry.ModName, "antigrief.permission", "admin");
                bannerbonusrange = ConfigManager.GetConfigIntOrDefault(NewColonyAPIEntry.ModName, "antigrief.bannerbonusradius", 50);
                if (bannerbonusrange < 0)
                    bannerbonusrange = 0;

                if (ConfigManager.GetConfigBooleanOrDefault(NewColonyAPIEntry.ModName, "antigrief.spawnprotection", false) == true)
                {
                    spawnprotection = true;
                    spawnprotectionrange = ConfigManager.GetConfigIntOrDefault(NewColonyAPIEntry.ModName, "antigrief.spawnradius", 300);
                    if (spawnprotectionrange < 0)
                        spawnprotectionrange = 0;

                    spawnlocation = ServerManager.TerrainGenerator.GetDefaultSpawnLocation();
                }

                Helpers.Logging.WriteLog(
                    NewColonyAPIEntry.ModName,
                    string.Format(
                        "[AntiGrief] Banner Protection: {0} with {1} range, Spawn Protection: {2} with {3} range",
                        antigrief ? "Enabled" : "Disabled",
                        GetBannerRadius(),
                        spawnprotection ? "Enabled" : "Disabled",
                        spawnprotectionrange),
                    Helpers.Logging.LogType.Loading,
                    true);
            }
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnTryChangeBlock, NewColonyAPIEntry.Naming + "Antigriefing")]
        public static void OnTryChangeBlock(ModLoader.OnTryChangeBlockData blockData)
        {
            if (antigrief)
            {
                if (blockData.RequestOrigin.Type == BlockChangeRequestOrigin.EType.Player)
                {
                    if (blockData.TypeNew == ItemTypes.GetType("water"))
                    {
                        Helpers.Chat.Send(blockData.RequestOrigin.AsPlayer, "Not allowed to place water!");
                        blockData.CallbackState = ModLoader.OnTryChangeBlockData.ECallbackState.Cancelled;
                        blockData.CallbackConsumedResult = EServerChangeBlockResult.CancelledByCallback;
                        return;
                    }

                    if (OutofSpawn(blockData.Position, blockData.RequestOrigin.AsPlayer) == false)
                    {
                        Helpers.Chat.Send(blockData.RequestOrigin.AsPlayer, string.Format("Too close to spawn!  Must be {0} blocks from spawn!", spawnprotectionrange));
                        blockData.InventoryItemResults.Clear();
                        blockData.CallbackState = ModLoader.OnTryChangeBlockData.ECallbackState.Cancelled;
                        blockData.CallbackConsumedResult = EServerChangeBlockResult.CancelledByCallback;
                        return;
                    }
                    if (OutofBannerRange(blockData.TypeNew, blockData.Position, blockData.RequestOrigin.AsPlayer, out BlockEntities.Implementations.BannerTracker.Banner banner) == false)
                    {
                        Helpers.Chat.Send(blockData.RequestOrigin.AsPlayer, string.Format("Too close to {0} : {1}, must be {2} blocks from a banner", banner.Colony.Name, banner.Position, GetBannerRadius()));
                        blockData.InventoryItemResults.Clear();
                        blockData.CallbackState = ModLoader.OnTryChangeBlockData.ECallbackState.Cancelled;
                        blockData.CallbackConsumedResult = EServerChangeBlockResult.CancelledByCallback;
                        return;
                    }
                }
            }
        }

        private static bool OutofSpawn(Pipliz.Vector3Int block, Players.Player p)
        {
            if (Helpers.Player.ExactPermission(p, ultimatepermission))
                return true;
            if (Helpers.Player.ExactPermission(p, permission))
                return true;

            int dx = System.Math.Abs((int)spawnlocation.x - block.x);
            int dz = System.Math.Abs((int)spawnlocation.z - block.z);

            if (dx < spawnprotectionrange && dz < spawnprotectionrange)
                return false;

            return true;
        }

        public static bool OutofBannerRange(ItemTypes.ItemType itemType, Pipliz.Vector3Int position, Players.Player player, out BlockEntities.Implementations.BannerTracker.Banner banner)
        {
            banner = null;
            if (Helpers.Player.ExactPermission(player, ultimatepermission))
                return true;
            if (Helpers.Player.ExactPermission(player, permission))
                return true;

            if (itemType == ItemTypes.GetType("banner"))
            {
                foreach (var item in ServerManager.ColonyTracker.ColoniesByID.Values)
                {
                    if (Vector3.Distance(new Vector3(position.x, position.y, position.z),
                        new Vector3(item.Banners[0].Position.x, item.Banners[0].Position.y, item.Banners[0].Position.z)) < GetBannerRadius())
                    {
                        if (item.Owners[0] != player)
                        {
                            return false;
                        }
                    }
                }

                return true;
            }

            if (ServerManager.BlockEntityTracker.BannerTracker.TryGetClosest(position, out banner, GetBannerRadius()))
            {
                if (banner.Colony.Owners.ContainsByReference(player) == false)
                    return false;
            }

            return true;
        }

        private static int GetBannerRadius()
        {
            return ServerManager.ServerSettings.Colony.ExclusiveRadius + bannerbonusrange;
        }
    }
}