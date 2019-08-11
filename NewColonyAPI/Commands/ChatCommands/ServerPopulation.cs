using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhentrixGames.NewColonyAPI.Commands.ChatCommands
{
    [ChatCommandManager.NCAPICommand]
    public class ServerPopulation : BaseChatCommand
    {
        public ServerPopulation() : base("/serverpop", null) { }

        protected override bool RunCommand(Players.Player id, string args, List<string> splits)
        {
            Helpers.Chat.SendSilent(id, string.Format("There are {0}/{1} players online.  {2} different players been on the server.", Players.CountConnected, ServerManager.HostingSettings.MaxPlayerCount, Players.PlayerDatabase.Count));
            return true;
        }
    }
}
