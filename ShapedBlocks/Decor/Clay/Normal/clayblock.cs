using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor.Clay.Black
{
    [NCAPIRecipe]
    public class ClayBlockRecipe : BaseRecipe
    {
        public ClayBlockRecipe() : base("clayblockrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblock", 1));
        }
    }

    [NCAPIType]
    public class ClayBlock : BaseType
    {
        public ClayBlock() : base("clayblock", false)
        {
            this.IsPlaceable = true;
            this.Icon = NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModIconDirectory, "clayblock.png");
            this.SideAll = "clayblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }
}