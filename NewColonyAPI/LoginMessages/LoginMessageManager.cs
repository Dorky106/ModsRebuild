using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhentrixGames.NewColonyAPI.LoginMessages
{
    [ModLoader.ModManager]
    internal class LoginMessageManager
    {
        private static List<string> messages = new List<string>();
        private static Helpers.Chat.ChatColour colour = Helpers.Chat.ChatColour.white;
        private static Helpers.Chat.ChatStyle style = Helpers.Chat.ChatStyle.normal;

        public static void Init()
        {
            messages.Add("Init Function needs to be finished!");
        }


        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnPlayerConnectedLate, NewColonyAPIEntry.Naming + "OnPlayerConnectedLate")]
        public static void SendMessage(Players.Player p)
        {
            foreach (var mod in Mods.ModManager.GetMods().Values)
            {
                if(Helpers.Player.IsSinglePlayer(p))
                {
                    if(mod.Version != null && mod.UpdateURL != null)
                    {
                        Helpers.Chat.SendSilent(p, Mods.VersionCheck.SinglePlayerVersionCheck(mod.ModName, mod.Version, mod.UpdateURL), Helpers.Chat.ChatColour.lime, Helpers.Chat.ChatStyle.bolditalic);
                    }
                }
                else
                {
                    if(mod.Version != null)
                    {
                        Helpers.Chat.SendSilent(p, "The server is using " + mod.ModName + " v" + mod.Version.ToString(), Helpers.Chat.ChatColour.lime, Helpers.Chat.ChatStyle.bolditalic);
                    }
                }
            }
            foreach (string msg in messages)
            {
                Helpers.Chat.SendSilent(p, msg, Helpers.Chat.ChatColour.yellow, Helpers.Chat.ChatStyle.bolditalic);
            }
        }
    }
}
