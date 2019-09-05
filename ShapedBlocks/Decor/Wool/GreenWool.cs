using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Wool
{
    [NCAPIRecipe]
    public class GreenWoolRecipe : BaseRecipe
    {
        public GreenWoolRecipe() : base("Test.Greenwool", "pipliz.crafter", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("GreenWool", 1));
        }
    }

    [NCAPIType]
    public class GreenWool : BaseType
    {
        public GreenWool() : base("GreenWool", false)
        {
            this.SideAll = "GreenWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "GreenWool.png");
        }
    }
}