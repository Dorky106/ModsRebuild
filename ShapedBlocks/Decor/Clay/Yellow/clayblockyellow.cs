using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor.Clay.Black
{
    [NCAPIRecipe]
    public class ClayBlockYellowRecipe : BaseRecipe
    {
        public ClayBlockYellowRecipe() : base("clayblockyellowrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockyellow", 1));
        }
    }

    [NCAPIType]
    public class ClayBlockYellow : BaseType
    {
        public ClayBlockYellow() : base("clayblockyellow", false)
        {
            this.IsPlaceable = true;
            this.Icon = NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockyellow.png");
            this.SideAll = "clayblockyellow";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }
}