using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor.Clay.Black
{
    [NCAPIRecipe]
    public class ClayBlockBrownRecipe : BaseRecipe
    {
        public ClayBlockBrownRecipe() : base("clayblockbluerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbrown", 1));
        }
    }

    [NCAPIType]
    public class ClayBlockBrown : BaseType
    {
        public ClayBlockBrown() : base("clayblockbrown", false)
        {
            this.IsPlaceable = true;
            this.Icon = NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbrown.png");
            this.SideAll = "clayblockbrown";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }
}