using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor.Clay.Black
{
    [NCAPIRecipe]
    public class ClayBlockRedRecipe : BaseRecipe
    {
        public ClayBlockRedRecipe() : base("clayblockredrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockred", 1));
        }
    }

    [NCAPIType]
    public class ClayBlockRed : BaseType
    {
        public ClayBlockRed() : base("clayblockred", false)
        {
            this.IsPlaceable = true;
            this.Icon = NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockred.png");
            this.SideAll = "clayblockred";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }
}