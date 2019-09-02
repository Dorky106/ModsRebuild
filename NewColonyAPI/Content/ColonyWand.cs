using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using Shared;
using System.Collections.Generic;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.NewColonyAPI.Content
{
    [NCAPIRecipe]
    public class ColonyWandRecipe : BaseRecipe
    {
        public ColonyWandRecipe() : base("ColonyWandRecipe", null, true)
        {
            this.Requirements = new List<InventoryItem>
            {
                new InventoryItem("planks", 10),
                new InventoryItem("copper", 10),
                new InventoryItem("tin", 10)
            };
            this.Result = new List<InventoryItem>
            {
                new InventoryItem("Colony wand")
            };
        }
    }

    [NCAPIType]
    public class ColonyWand : BaseType
    {
        public ColonyWand() : base("Colony wand", false)
        {
            this.IsPlaceable = false;
            this.Icon = Helpers.Utilities.MultiCombine(NewColonyAPIEntry.ModIconDirectory, "colonywand.png");
        }
    }

    [ModLoader.ModManager]
    public static class ColonyWandClick
    {
        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnPlayerClicked, NewColonyAPIEntry.Naming + "OnColonyWandClicked")]
        public static void OnPlayerClicked(Players.Player player, PlayerClickedData boxedData)
        {
            if (boxedData.ClickType == PlayerClickedData.EClickType.Left)
            {
                if (boxedData.TypeSelected == ItemTypes.IndexLookup.GetIndex("Colony wand"))
                {
                    ColonyWandUI.ColonyManager.SendUI(player);
                }
            }
        }
    }
}