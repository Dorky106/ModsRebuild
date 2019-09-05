using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor.Clay.Black
{
    [NCAPIRecipe]
    public class ClayBlockSilverRecipe : BaseRecipe
    {
        public ClayBlockSilverRecipe() : base("clayblocksilverrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocksilver", 1));
        }
    }

    [NCAPIType]
    public class ClayBlockSilver : BaseType
    {
        public ClayBlockSilver() : base("clayblocksilver", false)
        {
            this.IsPlaceable = true;
            this.Icon = NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocksilver.png");
            this.SideAll = "clayblocksilver";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }
}