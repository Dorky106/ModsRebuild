using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PhentrixGames.NewColonyAPI.Commands.ChatCommands
{
    [ChatCommandManager.NCAPICommand]
    public class Whisper : BaseChatCommand
    {
        public Whisper() : base("/w", null, "/w {playername} {message}")
        {
        }

        protected override bool RunCommand(Players.Player id, string args, List<string> splits)
        {
            var m = Regex.Match(args, @"/w (?<first>['].+?[']|[^ ]+)");
            if (m.Success)
            {
                if (TryMatchPlayer(id, m.Groups["first"].ToString(), out Players.Player target))
                {
                    if (target.ConnectionState == Players.EConnectionState.Connected)
                    {
                        int index = args.IndexOf(m.Groups["first"].ToString());
                        string msg = Helpers.Chat.BuildMessage("From: [" + id.Name + "] " + args.Substring(index + m.Groups["first"].ToString().Length + 1), Helpers.Chat.ChatColour.lightblue, Helpers.Chat.ChatStyle.normal);
                        Helpers.Chat.Send(target, msg);
                        msg = Helpers.Chat.BuildMessage("To :[" + target.Name + "] " + args.Substring(index + m.Groups["first"].ToString().Length + 1), Helpers.Chat.ChatColour.lightblue, Helpers.Chat.ChatStyle.normal);
                        Helpers.Chat.Send(id, msg);
                        return true;
                    }
                    else
                        Helpers.Chat.Send(id, string.Format("That player is currently no connected!"));
                    return true;
                }
                else
                {
                    Helpers.Chat.Send(id, string.Format("Could not find target player!"));
                    return true;
                }
            }
            return false;
        }
    }
}