using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Wool
{
    [NCAPIRecipe]
    public class CyanWoolRecipe : BaseRecipe
    {
        public CyanWoolRecipe() : base("Test.Cyanwool", "pipliz.crafter", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("CyanWool", 1));
        }
    }

    [NCAPIType]
    public class CyanWool : BaseType
    {
        public CyanWool() : base("CyanWool", true)
        {
            this.SideAll = "CyanWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "CyanWool.png");
        }
    }
}