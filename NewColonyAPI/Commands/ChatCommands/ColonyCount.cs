using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhentrixGames.NewColonyAPI.Commands.ChatCommands
{
    [ChatCommandManager.NCAPICommand]
    public class ColonyCount : BaseChatCommand
    {
        public ColonyCount() : base("/colonycount", null) { }

        protected override bool RunCommand(Players.Player id, string args, List<string> splits)
        {
            int colonycount = 0;
            foreach (int cid in ServerManager.ColonyTracker.ColoniesByID.Keys)
            {
                if(ServerManager.ColonyTracker.TryGet(cid, out Colony colony))
                {
                    if(colony.Owners.Length != 0)
                        colonycount++;
                }
            }
            Helpers.Chat.SendSilent(id, string.Format("There is a total of {0} colonies", colonycount));
            return true;
        }
    }
}
