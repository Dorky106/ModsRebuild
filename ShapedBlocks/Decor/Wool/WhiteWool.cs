using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Wool
{
    [NCAPIRecipe]
    public class WhiteWoolRecipe : BaseRecipe
    {
        public WhiteWoolRecipe() : base("Test.Whitewool", "pipliz.crafter", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("WhiteWool", 1));
        }
    }

    [NCAPIType]
    public class WhiteWool : BaseType
    {
        public WhiteWool() : base("WhiteWool", true)
        {
            this.SideAll = "WhiteWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "WhiteWool.png");
        }
    }
}