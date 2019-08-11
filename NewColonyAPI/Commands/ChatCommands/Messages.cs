using Chatting;
using Pipliz.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhentrixGames.NewColonyAPI.Commands.ChatCommands
{
    public class Messages : IChatCommand
    {
        public bool TryDoCommand(Players.Player player, string chat, List<string> splits)
        {
            if(chat.StartsWith("/"))
            {
                return false;
            }

            JSONNode chatColors = Configuration.ConfigManager.GetConfigNode(NewColonyAPIEntry.ModName, "chat.colors");
            string chatColor = "white";
            string chatStyle = "normal";
            string playerPerm = "";
            string chatPrefix = "";

            foreach (JSONNode perm in chatColors.LoopArray())
            {
                if(perm.TryGetAs("permissionstring", out string perName))
                {
                    if(Helpers.Player.ExactPermission(player, perName))
                    {
                        playerPerm = perName;
                        perm.TryGetAs("color", out chatColor);
                        perm.TryGetAs("style", out chatStyle);
                        perm.TryGetAs("prefix", out chatPrefix);
                        break;
                    }
                }
            }
            Helpers.Chat.ChatColour chatColourEnum = (Helpers.Chat.ChatColour)Enum.Parse(typeof(Helpers.Chat.ChatColour), chatColor);
            Helpers.Chat.ChatStyle chatStyleEnum = (Helpers.Chat.ChatStyle)Enum.Parse(typeof(Helpers.Chat.ChatStyle), chatStyle);
            if(chatPrefix == "")
            {
                Helpers.Chat.SendToAll(Helpers.Chat.BuildMessage(string.Format("[{0}] {1}", player.Name, chat), chatColourEnum, chatStyleEnum));
            }
            else
            {
                if (player.ID == NetworkID.Server)
                {
                    Helpers.Chat.SendToAll(Helpers.Chat.BuildMessage(string.Format("[{0}] [{1}] {2}", chatPrefix, "Server", chat), chatColourEnum, chatStyleEnum));
                }
                else
                {
                    Helpers.Chat.SendToAll(Helpers.Chat.BuildMessage(string.Format("[{0}] [{1}] {2}", chatPrefix, player.Name, chat), chatColourEnum, chatStyleEnum));
                }
            }

            return true;
        }
    }
}
