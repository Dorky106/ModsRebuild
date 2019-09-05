using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Wool
{
    [NCAPIRecipe]
    public class YellowWoolRecipe : BaseRecipe
    {
        public YellowWoolRecipe() : base("Test.Yellowwool", "pipliz.crafter", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("YellowWool", 1));
        }
    }

    [NCAPIType]
    public class YellowWool : BaseType
    {
        public YellowWool() : base("YellowWool", true)
        {
            this.SideAll = "YellowWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "YellowWool.png");
        }
    }
}