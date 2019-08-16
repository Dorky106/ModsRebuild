using System.Collections.Generic;
using static PhentrixGames.NewColonyAPI.Commands.ChatCommandManager;

namespace PhentrixGames.NewColonyAPI.Commands.ChatCommands
{
    [NCAPICommand]
    public class Online : BaseChatCommand
    {
        public Online() : base("/online", null)
        {
        }

        protected override bool RunCommand(Players.Player id, string args, List<string> splits)
        {
            List<string> online = new List<string>();
            for (int i = 0; i < Players.CountConnected; i++)
            {
                Players.Player p = Players.GetConnectedByIndex(i);
                online.Add(p.Name);
            }
            online.Sort();
            Helpers.Chat.SendSilent(id, string.Format("Players Online ({0}): {1}", Players.CountConnected, string.Join(", ", online.ToArray())));
            return true;
        }
    }
}