using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor.Clay.Black
{
    [NCAPIRecipe]
    public class ClayBlockOrangeRecipe : BaseRecipe
    {
        public ClayBlockOrangeRecipe() : base("clayblockorangerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockorange", 1));
        }
    }

    [NCAPIType]
    public class ClayBlockOrange : BaseType
    {
        public ClayBlockOrange() : base("clayblockorange", false)
        {
            this.IsPlaceable = true;
            this.Icon = NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockorange.png");
            this.SideAll = "clayblockorange";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }
}