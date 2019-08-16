using Chatting;
using System.Collections.Generic;

namespace PhentrixGames.NewColonyAPI.Commands.ChatCommands
{
    public class MasterChatCommand : IChatCommand
    {
        public bool TryDoCommand(Players.Player player, string chat, List<string> splits)
        {
            ChatCommandManager.GetCommandlist().TryGetValue(chat.Split(' ')[0], out BaseChatCommand command);

            if (command != null)
            {
                return command.TryDoCommand(player, chat, splits);
            }
            return false;
        }
    }
}