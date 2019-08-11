using System.Collections.Generic;

namespace PhentrixGames.NewColonyAPI.Commands.ChatCommands
{
    [ChatCommandManager.NCAPICommand]
    public class Help : BaseChatCommand
    {
        public Help() : base("/help", null) {}

        protected override bool RunCommand(Players.Player id, string args, List<string> splits)
        {
            List<string> commands = new List<string>();
            foreach (BaseChatCommand command in ChatCommandManager.GetCommandlist().Values)
            {
                if(command.HasPermissions(id))
                {
                    commands.Add(command.ChatCommandPrefix);
                }
            }
            Helpers.Chat.SendSilent(id, string.Join(", ", commands.ToArray()));
            return true;
        }
    }
}
