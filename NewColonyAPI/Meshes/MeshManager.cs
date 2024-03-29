﻿using System.Collections.Generic;
using System.IO;

namespace PhentrixGames.NewColonyAPI.Meshes
{
    [ModLoader.ModManager]
    public class MeshManager
    {
        private static Dictionary<string, Dictionary<string, string>> meshList = new Dictionary<string, Dictionary<string, string>>();

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterSelectedWorld, NewColonyAPIEntry.Naming + "LoadMeshes")]
        [ModLoader.ModCallbackDependsOn(NewColonyAPIEntry.Naming + "LoadConfigs")]
        [ModLoader.ModCallbackProvidesFor("pipliz.server.registertexturemappingtextures")]
        internal static void RegisterMeshs()
        {
            foreach (Mods.Mod mod in Mods.ModManager.GetMods().Values)
            {
                if (mod.ModName == null && mod.ModName == "")
                    return;

                string[] files = Directory.GetFiles(mod.ModFolder, "*", SearchOption.AllDirectories);

                string meshName = "";
                int count = 0;

                foreach (string file in files)
                {
                    if (file.EndsWith(".ply") || file.EndsWith(".obj"))
                    {
                        meshName = Path.GetFileNameWithoutExtension(file);
                        AddMesh(mod.ModName, meshName, file);
                        count++;
                    }
                }
                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, string.Format("Meshes Autoloaded: {0} from {1}", count, mod.ModName), Helpers.Logging.LogType.Loading);
            }
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AddItemTypes, NewColonyAPIEntry.Naming + "ClearMeshs")]
        internal static void ClearMeshs(Dictionary<string, ItemTypesServer.ItemTypeRaw> dict)
        {
            foreach (string id in meshList.Keys)
            {
                meshList[id].Clear();
            }
            meshList.Clear();
        }

        private static void AddMesh(string modName, string meshName, string meshPath)
        {
            if (meshList.ContainsKey(modName) == false)
            {
                meshList.Add(modName, new Dictionary<string, string>());
            }

            if (meshList[modName].ContainsKey(meshName) == false)
                meshList[modName].Add(meshName, meshPath);
            else
                Helpers.Logging.WriteLog(modName, string.Format("Mesh {0} already exists inside {1}", meshName, modName), Helpers.Logging.LogType.Issue);
        }

        public static bool GetMesh(string modName, string meshName, out string mesh)
        {
            mesh = "";

            if (meshList.ContainsKey(modName))
            {
                if (meshList[modName].ContainsKey(meshName))
                {
                    mesh = meshList[modName][meshName].Replace("\\", "/");
                    return true;
                }
            }

            return false;
        }
    }
}