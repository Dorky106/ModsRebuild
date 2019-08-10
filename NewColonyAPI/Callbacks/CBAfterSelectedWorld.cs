using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhentrixGames.NewColonyAPI.Callbacks
{
    [ModLoader.ModManager]
    public static class CBAfterSelectedWorld
    {
        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterSelectedWorld, NewColonyAPIEntry.Naming + "AfterSelectedWorld")]
        public static void AfterSelectedWorld()
        {
            foreach (string id in Mods.ModManager.GetMods().Keys)
            {
                Helpers.Logging.CreateLog(id);
            }
            LoginMessages.LoginMessageManager.Init();
        }
    }
}
