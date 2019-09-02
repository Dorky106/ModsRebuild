using PhentrixGames.NewColonyAPI.Mods;
using PhentrixGames.NewColonyAPI.Power;
using PhentrixGames.NewColonyAPI.Power.PowerJobs;
using System;
using System.Collections.Generic;
using System.IO;

namespace PhentrixGames.RiseoftheNewColonies
{
    internal static class Entry
    {
        public static Version APIVersion = new Version(3, 0, 0, 0);
        public const string ModName = "Rise of the New Colonies";
        public const string Naming = "PhentrixGames.RiseoftheNewColonies.";

        public static string ModFolder;
        public static string ModGamedataDirectory;
        public static string ModAudioDirectory;
        public static string ModMeshesDirectory;
        public static string ModSettingsDirectory;
        public static string ModTexturesDirectory;
        public static string ModIconDirectory;
        public static string ModMaterialsDirectory;
    }

    [ModLoader.ModManager]
    public static class CBEntryCallbacks
    {
        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnAssemblyLoaded, Entry.Naming + "OnAssemblyLoaded")]
        public static void OnAssemblyLoaded(string path)
        {
            Entry.ModFolder = Path.GetDirectoryName(path);
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterModsLoaded, Entry.Naming + "AfterModsLoaded")]
        [ModLoader.ModCallbackProvidesFor("PhentrixGames.NewColonyAPI.Dependencies")]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void AfterModsLoaded(List<ModLoader.ModDescription> mods)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            Entry.ModGamedataDirectory = NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModFolder, "gamedata");
            Entry.ModIconDirectory = NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModGamedataDirectory, "textures", "icons");
            Entry.ModMaterialsDirectory = NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModGamedataDirectory, "textures", "blocks");
            Entry.ModSettingsDirectory = NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModGamedataDirectory, "Settings");
            Entry.ModMeshesDirectory = NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModGamedataDirectory, "Meshes");

            ModManager.RegisterMod(Entry.ModName,
                Entry.ModFolder,
                Entry.APIVersion,
                "http://phentrixgames.com/mods/riseofthenewcolonies",
                Entry.ModSettingsDirectory);
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesDefined, Entry.Naming + "RegisterJobs")]
        [ModLoader.ModCallbackDependsOn("create_servermanager_trackers")]
        [ModLoader.ModCallbackDependsOn("pipliz.server.loadnpctypes")]
        [ModLoader.ModCallbackProvidesFor("create_savemanager")]
        public static void RegisterJobs()
        {
            if (PowerManager.IsEnabled())
            {
                GeneratorJobLitSettings gsettings = new GeneratorJobLitSettings("Generator", "phentrixgames.generator", new InventoryItem("planks"));
                ServerManager.BlockEntityCallbacks.RegisterEntityManager(new Jobs.BlockJobManager<GeneratorJobInstance>(gsettings));

                GeneratorJobWaterSettings g2settings = new GeneratorJobWaterSettings("Hydro Generator", "phentrixgames.hydrogenerator", new InventoryItem("bucketwater", 0), 7);
                ServerManager.BlockEntityCallbacks.RegisterEntityManager(new Jobs.BlockJobManager<GeneratorJobWaterInstance>(g2settings));

                MachineJobSettings msettings = new MachineJobSettings("Sawmill", "phentrixgames.sawmill");
                ServerManager.BlockEntityCallbacks.RegisterEntityManager(new Jobs.BlockJobManager<MachineJobInstance>(msettings));

                MachineJobSettings m2settings = new MachineJobSettings("Stone Crusher", "phentrixgames.stonecrusher", 20);
                ServerManager.BlockEntityCallbacks.RegisterEntityManager(new Jobs.BlockJobManager<MachineJobInstance>(m2settings));

                MachineJobSettings m3settings = new MachineJobSettings("Electric Forge", "phentrixgames.electricforge", 15);
                ServerManager.BlockEntityCallbacks.RegisterEntityManager(new Jobs.BlockJobManager<MachineJobInstance>(m3settings));
            }
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesDefined, Entry.Naming + "RecipeMapping")]
        [ModLoader.ModCallbackProvidesFor("pipliz.server.recipenpcload")]
        public static void RecipeMapping()
        {
            if (PowerManager.IsEnabled())
            {
                ServerManager.RecipeStorage.AddBlockToRecipeMapping("Sawmill", "phentrixgames.sawmill");
                ServerManager.RecipeStorage.AddBlockToRecipeMapping("Stone Crusher", "phentrixgames.stonecrusher");
                ServerManager.RecipeStorage.AddBlockToRecipeMapping("Electric Forge", "phentrixgames.electricforge");
            }
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterWorldLoad, Entry.Naming + ".LoadEvents")]
        public static void LoadEvents()
        {
            NewColonyAPI.Helpers.Logging.WriteLog(Entry.ModName, "Need to Register Events!", NewColonyAPI.Helpers.Logging.LogType.Info);
            /*
            if (ConfigManager.GetConfigBooleanOrDefault(Entry.ModName, "eventsenabled.plague", true))
                NewColonyAPI.Managers.EventManager.Register("Plague", new Classes.Events.Plague());
            if (ConfigManager.GetConfigBooleanOrDefault(Entry.ModName, "eventsenabled.migration", true))
                NewColonyAPI.Managers.EventManager.Register("Migration", new Classes.Events.Plague());
            */
        }
    }
}