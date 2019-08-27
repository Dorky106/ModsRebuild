using PhentrixGames.NewColonyAPI.Power;
using Shared;
using System;

namespace PhentrixGames.NewColonyAPI
{
    internal static class NewColonyAPIEntry
    {
        public const string ModName = "New Colony API";
        public const string Naming = "PhentrixGames.NewColonyAPI.";
        public static string ModFolder;
        public static string ModGamedataDirectory;
        public static string ModIconDirectory;
        public static string ModMaterialsDirectory;
        public static string ModSettingsDirectory;
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
            //Get all folder locations
            NewColonyAPIEntry.ModGamedataDirectory = Helpers.Utilities.MultiCombine(NewColonyAPIEntry.ModFolder, "gamedata");
            NewColonyAPIEntry.ModIconDirectory = Helpers.Utilities.MultiCombine(NewColonyAPIEntry.ModGamedataDirectory, "textures", "icons");
            NewColonyAPIEntry.ModMaterialsDirectory = Helpers.Utilities.MultiCombine(NewColonyAPIEntry.ModGamedataDirectory, "textures", "blocks");
            NewColonyAPIEntry.ModStructures = NewColonyAPIEntry.ModFolder.Substring(0, NewColonyAPIEntry.ModFolder.IndexOf("mods")).Replace("\\", "/") + "Structures/";
            NewColonyAPIEntry.ModBackupStructures = Helpers.Utilities.MultiCombine(NewColonyAPIEntry.ModGamedataDirectory, "BackupStructures");
            NewColonyAPIEntry.ModSettingsDirectory = Helpers.Utilities.MultiCombine(NewColonyAPIEntry.ModGamedataDirectory, "Settings");

            NewColonyAPIEntry.GameSaveFolder = NewColonyAPIEntry.ModFolder.Substring(0, NewColonyAPIEntry.ModFolder.IndexOf("mods")).Replace("\\", "/") + "savegames/";

            Mods.ModManager.RegisterMod(
                NewColonyAPIEntry.ModName,
                NewColonyAPIEntry.ModFolder,
                new Version(999, 999, 999, 999),
                "http://phentrixgames.com/mods/newcolonyapi",
                NewColonyAPIEntry.ModSettingsDirectory);

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

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesDefined, NewColonyAPIEntry.Naming + "RegisterJobs")]
        [ModLoader.ModCallbackDependsOn("create_servermanager_trackers")]
        [ModLoader.ModCallbackDependsOn("pipliz.server.loadnpctypes")]
        [ModLoader.ModCallbackProvidesFor("create_savemanager")]
        public static void RegisterJobs()
        {
            if (PowerManager.IsEnabled())
            {
                Power.PowerJobs.GeneratorJobSettings settings = new Power.PowerJobs.GeneratorJobSettings("BasicBlock", "phentrixgames.generator", new InventoryItem("planks"));
                ServerManager.BlockEntityCallbacks.RegisterEntityManager(new Jobs.BlockJobManager<Power.PowerJobs.GeneratorJobInstance>(settings));

                Power.PowerJobs.MachineJobSettings msettings = new Power.PowerJobs.MachineJobSettings("Sawmill", "phentrixgames.sawmill");
                ServerManager.BlockEntityCallbacks.RegisterEntityManager(new Jobs.BlockJobManager<Power.PowerJobs.MachineJobInstance>(msettings));
            }
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesDefined, NewColonyAPIEntry.Naming + "RecipeMapping")]
        [ModLoader.ModCallbackProvidesFor("pipliz.server.recipenpcload")]
        public static void RecipeMapping()
        {
            if (PowerManager.IsEnabled())
            {
                ServerManager.RecipeStorage.AddBlockToRecipeMapping("Sawmill", "phentrixgames.sawmill");
            }
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnPlayerClicked, NewColonyAPIEntry.Naming + "OnPlayerClickTester")]
        public static void OnPlayerClicked(Players.Player player, PlayerClickedData clickedData)
        {
            if (Helpers.Player.ExactPermission(player, "Master"))
            {
                if (clickedData.ClickType == PlayerClickedData.EClickType.Left)
                {
                    if (clickedData.HitType == PlayerClickedData.EHitType.Block)
                    {
                        Helpers.Chat.SendSilent(player, ItemTypes.IndexLookup.GetName(clickedData.GetVoxelHit().TypeHit));
                    }
                }
            }
        }
    }
}