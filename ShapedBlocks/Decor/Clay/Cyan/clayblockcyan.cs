using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor.Clay.Black
{
    [NCAPIRecipe]
    public class ClayBlockCyanRecipe : BaseRecipe
    {
        public ClayBlockCyanRecipe() : base("clayblockcyanrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockcyan", 1));
        }
    }

    [NCAPIType]
    public class ClayBlockCyan : BaseType
    {
        public ClayBlockCyan() : base("clayblockcyan", false)
        {
            this.IsPlaceable = true;
            this.Icon = NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockcyan.png");
            this.SideAll = "clayblockcyan";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }
}