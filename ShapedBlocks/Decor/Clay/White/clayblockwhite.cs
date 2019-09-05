using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor.Clay.Black
{
    [NCAPIRecipe]
    public class ClayBlockWhiteRecipe : BaseRecipe
    {
        public ClayBlockWhiteRecipe() : base("clayblockwhiterecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockwhite", 1));
        }
    }

    [NCAPIType]
    public class ClayBlockWhite : BaseType
    {
        public ClayBlockWhite() : base("clayblockwhite", false)
        {
            this.IsPlaceable = true;
            this.Icon = NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockwhite.png");
            this.SideAll = "clayblockwhite";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }
}