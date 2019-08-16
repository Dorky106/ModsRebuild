using System.Collections.Generic;

namespace PhentrixGames.NewColonyAPI.Commands
{
    public abstract class BaseChatCommand
    {
        public string ChatCommandPrefix;
        public string[] Permissions = null;
        public string[] ValidUsage = null;

        public BaseChatCommand(string prefix, string[] permissions, params string[] validuse)
        {
            ChatCommandPrefix = prefix;
            ValidUsage = validuse;

            if (permissions != null)
            {
                List<string> validperms = new List<string>();
                foreach (string permission in permissions)
                {
                    if (permission != null && permission != "")
                        validperms.Add(permission);
                }
                Permissions = validperms.ToArray();
            }
        }

        protected abstract bool RunCommand(Players.Player id, string args, List<string> splits);

        public bool TryDoCommand(Players.Player player, string chatItem, List<string> splits)
        {
            bool correct = false;
            if (HasPermissions(player))
            {
                correct = RunCommand(player, chatItem, splits);
            }
            if (correct == false)
            {
                foreach (string usage in ValidUsage)
                {
                    Helpers.Chat.SendSilent(player, usage, Helpers.Chat.ChatColour.orange);
                }
            }

            return true;
        }

        protected bool TryMatchPlayer(Players.Player caller, string str, out Players.Player player, bool response = false)
        {
            if (Chatting.CommandManager.TryMatchKnownPlayer(caller, str, response, out player))
                return true;

            return false;
        }

        public bool HasPermissions(Players.Player player)
        {
            if (Permissions == null)
                return true;
            if (Permissions.Length == 0)
                return true;

            foreach (string permission in Permissions)
            {
                if (Helpers.Player.ExactPermission(player, permission))
                {
                    return true;
                }
            }

            return false;
        }
    }
}