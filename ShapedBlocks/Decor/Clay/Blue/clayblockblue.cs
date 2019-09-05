using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor.Clay.Black
{
    [NCAPIRecipe]
    public class ClayBlockBlueRecipe : BaseRecipe
    {
        public ClayBlockBlueRecipe() : base("clayblockbluerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblue", 1));
        }
    }

    [NCAPIType]
    public class ClayBlockBlue : BaseType
    {
        public ClayBlockBlue() : base("clayblockblue", false)
        {
            this.IsPlaceable = true;
            this.Icon = NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblue.png");
            this.SideAll = "clayblockblue";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }
}