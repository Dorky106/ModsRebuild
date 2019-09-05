using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Wool
{
    [NCAPIRecipe]
    public class BlackWoolRecipe : BaseRecipe
    {
        public BlackWoolRecipe() : base("Test.Blackwool", "pipliz.crafter", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("BlackWool", 1));
        }
    }

    [NCAPIType]
    public class BlackWool : BaseType
    {
        public BlackWool() : base("BlackWool", false)
        {
            this.SideAll = "BlackWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "BlackWool.png");
        }
    }
}