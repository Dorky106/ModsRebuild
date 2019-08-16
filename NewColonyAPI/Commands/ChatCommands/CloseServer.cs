using Pipliz;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PhentrixGames.NewColonyAPI.Commands.ChatCommands
{
    [ChatCommandManager.NCAPICommand]
    public class CloseServer : BaseChatCommand
    {
        public CloseServer() : base("/closeserver", new string[] { "admin" }, "/closeserver {minutes}")
        { }

        protected override bool RunCommand(Players.Player id, string args, List<string> splits)
        {
            var m = Regex.Match(args, @"/closeserver (?<first>['].+?[']|[^ ]+)");

            if (m.Success)
            {
                if (Int32.TryParse(m.Groups["first"].Value, out int tmp))
                {
                    if (tmp >= 15 && tmp <= 60)
                    {
                        GameServer.InitClose(tmp);
                        return true;
                    }
                    Helpers.Chat.SendSilent(id, "{mins} value must be between 15 and 60!");
                    return true;
                }
            }

            return false;
        }
    }

    [ModLoader.ModManager]
    internal static class GameServer
    {
        private static int update = 0, till = 0, remaining = 60;

        internal static void InitClose(int mins)
        {
            remaining = mins;
            update = Time.SecondsSinceStartInt;
            till = update + (mins * 60);
            Helpers.Chat.SendToAll(string.Format("Server shutting down in {0} minutes", remaining), Helpers.Chat.ChatColour.magenta, Helpers.Chat.ChatStyle.bolditalic);
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnFixedUpdate, NewColonyAPIEntry.Naming + "GameServer.Update")]
        internal static void Update()
        {
            if (till != 0)
            {
                if (Time.SecondsSinceStartInt >= till)
                {
                    UnityEngine.Application.Quit();
                }

                if (update + 60 <= Time.SecondsSinceStartInt)
                {
                    update = Time.SecondsSinceStartInt;
                    remaining--;
                    if (remaining == 45 || remaining == 30 || remaining == 15 || remaining == 10 || remaining == 5 || remaining == 4 || remaining == 3 || remaining == 2 || remaining == 1)
                    {
                        Helpers.Chat.SendToAll(string.Format("Server shutting down in {0} minutes", remaining), Helpers.Chat.ChatColour.magenta, Helpers.Chat.ChatStyle.bolditalic);
                        return;
                    }
                }
            }
        }
    }
}