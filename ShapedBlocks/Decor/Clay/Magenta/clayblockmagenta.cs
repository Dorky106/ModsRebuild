using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor.Clay.Black
{
    [NCAPIRecipe]
    public class ClayBlockMagentaRecipe : BaseRecipe
    {
        public ClayBlockMagentaRecipe() : base("clayblockmagentarecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockmagenta", 1));
        }
    }

    [NCAPIType]
    public class ClayBlockMagenta : BaseType
    {
        public ClayBlockMagenta() : base("clayblockmagenta", false)
        {
            this.IsPlaceable = true;
            this.Icon = NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockmagenta.png");
            this.SideAll = "clayblockmagenta";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }
}