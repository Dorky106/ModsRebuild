using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace PhentrixGames.NewColonyAPI.Mods
{
    public static class ModManager
    {
        private static Dictionary<string, Mod> ModList = new Dictionary<string, Mod>();
        private static List<Assembly> assemblies = new List<Assembly>();
        private static FileStream ServerLock = null;
        public static void RegisterMod(string modName, string modFolder, Version version = null, string modUpdateURL = null, string modConfigFolder = null, string configName = "config.json", List<string> deps = null)
        {
            //Check if Mod is already registered
            if(ModList.ContainsKey(modName) == false)
            {
                //Should version checking happen?
                if (version != null && modUpdateURL != null)
                {
                    //Run Version Check!
                }

                ModList.Add(modName, new Mod(modName, modFolder, version, modUpdateURL, modConfigFolder, configName, deps));

                //Check for assembly
                foreach (ModLoader.ModDescription desc in ModLoader.LoadedMods)
                {
                    if (desc.name == modName)
                    {
                        assemblies.Add(desc.LoadedAssembly);
                    }
                }
            }
        }

        internal static void CheckDeps()
        {
            bool chk = true;
            if (ServerLock == null)
            {
                if(ModList.Count != 0)
                {
                    foreach (Mods.Mod mod in ModList.Values)
                    {
                        if (mod.Dependencies != null)
                        {
                            foreach (string dep in mod.Dependencies)
                            {
                                if (ModList.ContainsKey(dep) == false)
                                {
                                    Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, mod.ModName + " is missing dependency " + dep, Helpers.Logging.LogType.Issue);
                                    Lock();
                                    chk = false;
                                }
                            }
                        }
                    }
                    if(chk == false)
                    {
                        Lock();
                    }
                }
            }
        }

        internal static void Lock()
        {
            if(ServerLock == null)
            {
                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Locking server due to missing Dependency(s)", Helpers.Logging.LogType.Issue);
                int index = NewColonyAPIEntry.ModFolder.LastIndexOf("\\mods");
                string folder = NewColonyAPIEntry.ModFolder.Substring(0, index);
                folder = Helpers.Utilities.MultiCombine(folder, "savegames", "serverLock");
                ServerLock = File.Open(folder, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
            }
        }

        public static Mod GetMod(string name)
        {
            if (ModList.ContainsKey(name))
                return ModList[name];

            return null;
        }
        public static Dictionary<string, Mod> GetMods()
        {
            return ModList;
        }

        internal static void Unlock()
        {
            if (ServerLock != null)
            {
                ServerLock.Close();
            }
        }
        internal static void ClearAssemblies()
        {
            assemblies.Clear();
        }
    }
}
