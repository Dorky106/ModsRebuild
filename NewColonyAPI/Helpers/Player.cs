using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhentrixGames.NewColonyAPI.Helpers
{
    public static class Player
    {
        public static bool CheckPermission(Players.Player player, string permission)
        {
            return PermissionsManager.CheckAndWarnPermission(player, permission);
        }
        public static bool ExactPermission(Players.Player player, string permission)
        {
            return PermissionsManager.HasPermissionExact(player, permission);
        }
        public static bool IsSinglePlayer(Players.Player player)
        {
            if(player.ID.steamID.m_SteamID != 0)
            {
                return false;
            }
            return true;
        }
    }
}
