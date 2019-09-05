using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Wool
{
    [NCAPIRecipe]
    public class PurpleWoolRecipe : BaseRecipe
    {
        public PurpleWoolRecipe() : base("Test.Purplewool", "pipliz.crafter", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("PurpleWool", 1));
        }
    }

    [NCAPIType]
    public class PurpleWool : BaseType
    {
        public PurpleWool() : base("PurpleWool", true)
        {
            this.SideAll = "PurpleWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "PurpleWool.png");
        }
    }
}