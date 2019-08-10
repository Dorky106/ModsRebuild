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
            Configuration.ConfigManager.LoadConfigs();
            LoginMessages.LoginMessageManager.Init();
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterSelectedWorld, NewColonyAPIEntry.Naming + "LoadTextures")]
        [ModLoader.ModCallbackDependsOn(NewColonyAPIEntry.Naming + "AfterSelectedWorld")]
        [ModLoader.ModCallbackProvidesFor("pipliz.server.registertexturemappingtextures")]
        public static void LoadTextures()
        {
            foreach (Mods.Mod mod in Mods.ModManager.GetMods().Values)
            {
                Helpers.Logging.WriteLog(mod.ModName, "random crap", Helpers.Logging.LogType.Info);
                Meshes.MeshManager.RegisterMeshs(mod.ModName, mod.ModFolder);
            }
        }
    }
}
