using Pipliz.JSON;
using System;
using System.Collections.Generic;

namespace PhentrixGames.NewColonyAPI.LoginMessages
{
    [ModLoader.ModManager]
    internal class LoginMessageManager
    {
        private static List<string> messages = new List<string>();
        private static Helpers.Chat.ChatColour colour = Helpers.Chat.ChatColour.white;
        private static Helpers.Chat.ChatStyle style = Helpers.Chat.ChatStyle.normal;

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterSelectedWorld, NewColonyAPIEntry.Naming + "LoginMessages")]
        [ModLoader.ModCallbackDependsOn(NewColonyAPIEntry.Naming + "LoadConfigs")]
        public static void Init()
        {
            string logincolor = Configuration.ConfigManager.GetConfigStringOrDefault(NewColonyAPIEntry.ModName, "loginmessages.color", "yellow");
            if (Enum.IsDefined(typeof(Helpers.Chat.ChatColour), logincolor))
            {
                if (Enum.TryParse(logincolor, out colour) == false)
                {
                    Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Unable to get loginmessages.color!", Helpers.Logging.LogType.Issue, true);
                }
            }

            string loginstyle = Configuration.ConfigManager.GetConfigStringOrDefault(NewColonyAPIEntry.ModName, "loginmessages.style", "normal");
            if (Enum.IsDefined(typeof(Helpers.Chat.ChatStyle), loginstyle))
            {
                if (Enum.TryParse(loginstyle, out style) == false)
                {
                    Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Unable to get loginmessages.style!", Helpers.Logging.LogType.Issue, true);
                }
            }

            JSONNode loginmsgs = Configuration.ConfigManager.GetConfigNode(NewColonyAPIEntry.ModName, "loginmessages.list");
            foreach (JSONNode msg in loginmsgs.LoopArray())
            {
                messages.Add(msg.GetAs<string>());
            }
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnPlayerConnectedLate, NewColonyAPIEntry.Naming + "OnPlayerConnectedLate")]
        public static void SendMessage(Players.Player p)
        {
            foreach (var mod in Mods.ModManager.GetMods().Values)
            {
                if (Helpers.Player.IsSinglePlayer(p))
                {
                    if (mod.Version != null && mod.UpdateURL != null)
                    {
                        Helpers.Chat.SendSilent(p, Mods.VersionCheck.SinglePlayerVersionCheck(mod.ModName, mod.Version, mod.UpdateURL), Helpers.Chat.ChatColour.lime, Helpers.Chat.ChatStyle.bolditalic);
                    }
                }
                else
                {
                    if (mod.Version != null)
                    {
                        Helpers.Chat.SendSilent(p, "The server is using " + mod.ModName + " v" + mod.Version.ToString(), Helpers.Chat.ChatColour.lime, Helpers.Chat.ChatStyle.bolditalic);
                    }
                }
            }
            foreach (string msg in messages)
            {
                Helpers.Chat.SendSilent(p, msg, colour, style);
            }
        }
    }
}