using PhentrixGames.NewColonyAPI.Mods;
using System.Collections.Generic;
using System.IO;

namespace PhentrixGames.Letters
{
    public class Entry
    {
        public const string ModName = "Letters";
        public const string Naming = "PhentrixGames.Letters.";

        public static string ModFolder;
        public static string ModGamedataDirectory;
        public static string ModMaterialsDirectory;
        public static string ModIconDirectory;
        public static string ModSettingsDirectory;
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
        [ModLoader.ModCallbackDependsOn("PhentrixGames.NewColonyAPI.AfterModsLoaded")]
        [ModLoader.ModCallbackProvidesFor("PhentrixGames.NewColonyAPI.Dependencies")]
        public static void AfterModsLoaded(List<ModLoader.ModDescription> mods)
        {
            Entry.ModGamedataDirectory = PhentrixGames.NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModFolder, "gamedata");
            Entry.ModMaterialsDirectory = PhentrixGames.NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModGamedataDirectory, "textures", "blocks");
            Entry.ModIconDirectory = PhentrixGames.NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModGamedataDirectory, "textures", "icons");
            Entry.ModSettingsDirectory = PhentrixGames.NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModGamedataDirectory, "settings");

            ModManager.RegisterMod(
                Entry.ModName,
                Entry.ModFolder,
                null,
                null,
                Entry.ModSettingsDirectory);
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AddItemTypes, Entry.Naming + ".AddItemTypes")]
        [ModLoader.ModCallbackProvidesFor("pipliz.server.applymoditempatches")]
        public static void AfterAddingBaseTypes(Dictionary<string, ItemTypesServer.ItemTypeRaw> dict)
        {
            LetterFactory.InitBlocks();
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesDefined, Entry.Naming + "AfterItemTypesDefinedPlayer")]
        [ModLoader.ModCallbackProvidesFor("pipliz.server.recipeplayerload")]
        [ModLoader.ModCallbackProvidesFor("pipliz.server.recipenpcload")]
        public static void AfterItemTypesDefinedPlayer()
        {
            LetterFactory.InitRecipes();
        }
    }
}