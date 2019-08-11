using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhentrixGames.NewColonyAPI.Commands.ChatCommands
{
    [ChatCommandManager.NCAPICommand]
    public class AdminChat : BaseChatCommand
    {
        public AdminChat() : base("/admin", new string[] { "admin" }) { }

        protected override bool RunCommand(Players.Player id, string args, List<string> splits)
        {
            string message = args.Replace("/admin ", "");

            for (int i = 0; i < Players.CountConnected; i++)
            {
                Players.Player p = Players.GetConnectedByIndex(i);
                if(HasPermissions(p))
                {
                    Helpers.Chat.Send(p, Helpers.Chat.BuildMessage(string.Format("[AdminChat][{0}]: {1}", id.Name, message), Helpers.Chat.ChatColour.blue));
                }
            }
            return true;
        }
    }
}
