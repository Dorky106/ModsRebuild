using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Wool
{
    [NCAPIRecipe]
    public class SilverWoolRecipe : BaseRecipe
    {
        public SilverWoolRecipe() : base("Test.Silverwool", "pipliz.crafter", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("SilverWool", 1));
        }
    }

    [NCAPIType]
    public class SilverWool : BaseType
    {
        public SilverWool() : base("SilverWool", true)
        {
            this.SideAll = "SilverWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "SilverWool.png");
        }
    }
}