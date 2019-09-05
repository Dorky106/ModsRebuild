using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor.Clay.Black
{
    [NCAPIRecipe]
    public class ClayBlockPurpleRecipe : BaseRecipe
    {
        public ClayBlockPurpleRecipe() : base("clayblockpurplerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpurple", 1));
        }
    }

    [NCAPIType]
    public class ClayBlockPurple : BaseType
    {
        public ClayBlockPurple() : base("clayblockpurple", false)
        {
            this.IsPlaceable = true;
            this.Icon = NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpurple.png");
            this.SideAll = "clayblockpurple";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }
}