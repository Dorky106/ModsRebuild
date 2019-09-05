using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Wool
{
    [NCAPIRecipe]
    public class BlueWoolRecipe : BaseRecipe
    {
        public BlueWoolRecipe() : base("Test.Bluewool", "pipliz.crafter", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("BlueWool", 1));
        }
    }

    [NCAPIType]
    public class BlueWool : BaseType
    {
        public BlueWool() : base("BlueWool", false)
        {
            this.SideAll = "BlueWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "BlueWool.png");
        }
    }
}