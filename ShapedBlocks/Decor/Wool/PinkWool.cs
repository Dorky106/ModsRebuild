using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Wool
{
    [NCAPIRecipe]
    public class PinkWoolRecipe : BaseRecipe
    {
        public PinkWoolRecipe() : base("Test.Pinkwool", "pipliz.crafter", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("PinkWool", 1));
        }
    }

    [NCAPIType]
    public class PinkWool : BaseType
    {
        public PinkWool() : base("PinkWool", true)
        {
            this.SideAll = "PinkWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "PinkWool.png");
        }
    }
}