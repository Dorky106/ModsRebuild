using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Wool
{
    [NCAPIRecipe]
    public class BrownWoolRecipe : BaseRecipe
    {
        public BrownWoolRecipe() : base("Test.Brownwool", "pipliz.crafter", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("BrownWool", 1));
        }
    }

    [NCAPIType]
    public class BrownWool : BaseType
    {
        public BrownWool() : base("BrownWool", true)
        {
            this.SideAll = "BrownWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "BrownWool.png");
        }
    }
}