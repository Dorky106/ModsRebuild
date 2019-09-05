using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor.Clay.Black
{
    [NCAPIRecipe]
    public class ClayBlockLightBlueRecipe : BaseRecipe
    {
        public ClayBlockLightBlueRecipe() : base("clayblocklightbluerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklightblue", 1));
        }
    }

    [NCAPIType]
    public class ClayBlockLightBlue : BaseType
    {
        public ClayBlockLightBlue() : base("clayblocklightblue", false)
        {
            this.IsPlaceable = true;
            this.Icon = NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklightblue.png");
            this.SideAll = "clayblocklightblue";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }
}