using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor.Clay.Black
{
    [NCAPIRecipe]
    public class ClayBlockBlackRecipe : BaseRecipe
    {
        public ClayBlockBlackRecipe() : base("clayblockblackrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblack", 1));
        }
    }

    [NCAPIType]
    public class ClayBlockBlack : BaseType
    {
        public ClayBlockBlack() : base("clayblockblack", false)
        {
            this.IsPlaceable = true;
            this.Icon = NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblack.png");
            this.SideAll = "clayblockblack";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }
}