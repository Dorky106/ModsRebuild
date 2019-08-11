using Pipliz.JSON;
using System;
using System.Linq;
using System.Reflection;

namespace PhentrixGames.NewColonyAPI.Textures
{
    [ModLoader.ModManager]
    public class TextureManager
    {
        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false)]
        public class NCAPITexture : Attribute { }


        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterSelectedWorld, NewColonyAPIEntry.Naming + "LoadTextures")]
        [ModLoader.ModCallbackDependsOn(NewColonyAPIEntry.Naming + "AfterSelectedWorld")]
        [ModLoader.ModCallbackProvidesFor("pipliz.server.registertexturemappingtextures")]
        public static void AutoDiscoverTextures()
        {
            int textureCount = 0;
            foreach (string modname in Mods.ModManager.GetMods().Keys)
            {
                Mods.Mod mod = Mods.ModManager.GetMod(modname);
                Assembly assembly = Mods.ModManager.GetAssembly(mod.ModName);
                var typelist = assembly.GetTypes()
                    .Where(t => (t.IsClass && t.IsDefined(typeof(NCAPITexture), true)));

                foreach (var t in typelist)
                {
                    try
                    {
                        BaseTexture texture = (BaseTexture)Activator.CreateInstance(t);
                        texture.Register();
                        textureCount++;
                    }
                    catch (MissingFieldException mme)
                    {
                        Helpers.Logging.WriteLog(modname, t.Name + " cannot be instantiated.  This probably isn't an error.", Helpers.Logging.LogType.Issue, true);
                        Pipliz.Log.WriteWarning(mme.Message);
                    }
                    catch (InvalidCastException ice)
                    {
                        Helpers.Logging.WriteLog(modname, t.Name + " doesn't properly implement our Type system. This probably isn't an error.", Helpers.Logging.LogType.Issue, true);
                        Pipliz.Log.WriteWarning(ice.Message);
                    }
                    catch (Exception e)
                    {
                        Helpers.Logging.WriteLog(modname, t.Name + " Type Error: " + e.Message + " |||| " + e.StackTrace, Helpers.Logging.LogType.Issue, true);
                        Pipliz.Log.WriteWarning(e.Message + e.StackTrace);
                    }
                }
            }
            Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Textures Autoloaded: " + textureCount, Helpers.Logging.LogType.Loading);
        }
    }
}
