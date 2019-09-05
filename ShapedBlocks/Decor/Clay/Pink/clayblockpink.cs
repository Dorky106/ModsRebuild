using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor.Clay.Black
{
    [NCAPIRecipe]
    public class ClayBlockPinkRecipe : BaseRecipe
    {
        public ClayBlockPinkRecipe() : base("clayblockpinkrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpink", 1));
        }
    }

    [NCAPIType]
    public class ClayBlockPink : BaseType
    {
        public ClayBlockPink() : base("clayblockpink", false)
        {
            this.IsPlaceable = true;
            this.Icon = NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpink.png");
            this.SideAll = "clayblockpink";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }
}