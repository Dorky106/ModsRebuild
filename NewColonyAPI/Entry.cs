﻿using System;

namespace PhentrixGames.NewColonyAPI
{
    internal static class NewColonyAPIEntry
    {
        public const string ModName = "New Colony API";
        public const string Naming = "PhentrixGames.NewColonyAPI.";
        public static Version APIVersion = new Version(2, 0, 0, 0);
        public static string ModFolder;
        public static string ModGamedataDirectory;
        public static string ModIconDirectory;
        public static string ModMaterialsDirectory;
        public static string ModSettingsDirectory;
        public static string ModLocalizationDirection;
        public static string ModStructures;
        public static string ModBackupStructures;

        public static string GameSaveFolder;
    }

    [ModLoader.ModManager]
    public static class CBEntryCallbacks
    {
        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnAssemblyLoaded, NewColonyAPIEntry.Naming + "OnAssemblyLoaded")]
        public static void OnAssemblyLoaded(string path)
        {
            NewColonyAPIEntry.ModFolder = System.IO.Path.GetDirectoryName(path);
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterModsLoaded, NewColonyAPIEntry.Naming + "AfterModsLoaded")]
        [ModLoader.ModCallbackProvidesFor(NewColonyAPIEntry.Naming + "Dependencies")]
        public static void AfterModsLoaded(System.Collections.Generic.List<ModLoader.ModDescription> mods)
        {
            NewColonyAPIEntry.GameSaveFolder = NewColonyAPIEntry.ModFolder.Substring(0, NewColonyAPIEntry.ModFolder.IndexOf("mods")).Replace("\\", "/") + "savegames/";

            Mods.ModManager.RegisterMod(NewColonyAPIEntry.ModName, NewColonyAPIEntry.ModFolder);

            foreach (var item in mods)
            {
                if (item.name.Contains("Settlers"))
                {
                    Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "New Colony API not compatible with Settlers!", Helpers.Logging.LogType.Issue);
                    Mods.ModManager.Lock();
                    break;
                }
            }

        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterModsLoaded, NewColonyAPIEntry.Naming + "Dependencies")]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Dependencies(System.Collections.Generic.List<ModLoader.ModDescription> mods)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            Mods.ModManager.CheckDeps();
        }
    }
}