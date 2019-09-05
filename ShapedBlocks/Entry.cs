using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Mods;
using System;
using System.Collections.Generic;
using System.IO;

namespace PhentrixGames.ShapedBlocks
{
    public class Entry
    {
        public const string ModName = "Shaped Blocks";
        public const string Naming = "PhentrixGames.ShapedBlocks";
        public static Version Version = new Version(0, 0, 0, 0);
        public static string ModFolder;
        public static string ModGamedataDirectory;
        public static string ModIconDirectory;
        public static string ModMaterialsDirectory;
    }

    [ModLoader.ModManager]
    public static class Callbacks
    {
        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnAssemblyLoaded, Entry.Naming + "OnAssemblyLoaded")]
        public static void OnAssemblyLoaded(string path)
        {
            Entry.ModFolder = Path.GetDirectoryName(path);
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterModsLoaded, Entry.Naming + "AfterModsLoaded")]
        [ModLoader.ModCallbackProvidesFor("PhentrixGames.NewColonyAPI.Dependencies")]
        public static void AfterModsLoaded(List<ModLoader.ModDescription> mods)
        {
            Entry.ModGamedataDirectory = Utilities.MultiCombine(Entry.ModFolder, "gamedata");
            Entry.ModIconDirectory = Utilities.MultiCombine(Entry.ModGamedataDirectory, "textures", "icons");
            Entry.ModMaterialsDirectory = Utilities.MultiCombine(Entry.ModGamedataDirectory, "textures", "blocks");

            ModManager.RegisterMod(Entry.ModName, Entry.ModFolder, Entry.Version, "http://phentrixgames.com/mods/shapedblocks");
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesDefined, Entry.Naming + "RegisterJobs")]
        [ModLoader.ModCallbackDependsOn("create_servermanager_trackers")]
        [ModLoader.ModCallbackDependsOn("pipliz.server.loadnpctypes")]
        [ModLoader.ModCallbackProvidesFor("create_savemanager")]
        public static void RegisterJobs()
        {
            Jobs.CraftingJobSettings ics = new Jobs.CraftingJobSettings("Wood Carving Station", "phentrixgames.woodcarver");
            ServerManager.BlockEntityCallbacks.RegisterEntityManager(new Jobs.BlockJobManager<Jobs.CraftingJobInstance>(ics));
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesDefined, Entry.Naming + "RecipeMapping")]
        [ModLoader.ModCallbackProvidesFor("pipliz.server.recipenpcload")]
        public static void RecipeMapping()
        {
            ServerManager.RecipeStorage.AddBlockToRecipeMapping("Wood Carving Station", "phentrixgames.woodcarver");
        }
    }
}