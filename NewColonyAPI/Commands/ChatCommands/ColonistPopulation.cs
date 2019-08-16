using System.Collections.Generic;

namespace PhentrixGames.NewColonyAPI.Commands.ChatCommands
{
    [ChatCommandManager.NCAPICommand]
    public class ColonistPopulation : BaseChatCommand
    {
        public ColonistPopulation() : base("/colonistpop", null)
        {
        }

        protected override bool RunCommand(Players.Player id, string args, List<string> splits)
        {
            int colonycount = 0, colonistcount = 0;
            foreach (int cid in ServerManager.ColonyTracker.ColoniesByID.Keys)
            {
                if (ServerManager.ColonyTracker.TryGet(cid, out Colony colony))
                {
                    if (colony.FollowerCount != 0)
                    {
                        colonycount++;
                        colonistcount += colony.FollowerCount;
                    }
                }
            }

            Helpers.Chat.SendSilent(id, string.Format("There is a total of {0} colonists between {1} colonies", colonistcount, colonycount));
            return true;
        }
    }
}