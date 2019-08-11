using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhentrixGames.NewColonyAPI.Commands.ChatCommands
{
    [ChatCommandManager.NCAPICommand]
    public class ModChat : BaseChatCommand
    {
        public ModChat() : base("/mod", new string[] { "admin", "mod" }) { }

        protected override bool RunCommand(Players.Player id, string args, List<string> splits)
        {
            string message = args.Replace("/mod ", "");
            for (int i = 0; i < Players.CountConnected; i++)
            {
                Players.Player p = Players.GetConnectedByIndex(i);
                if(HasPermissions(p))
                {
                    Helpers.Chat.Send(p, Helpers.Chat.BuildMessage(string.Format("[ModChat][{0}]: {1}", id.Name, message), Helpers.Chat.ChatColour.silver));
                }
            }
            return true;
        }
    }
}
