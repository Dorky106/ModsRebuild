using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Wool
{
    [NCAPIRecipe]
    public class OrangeWoolRecipe : BaseRecipe
    {
        public OrangeWoolRecipe() : base("Test.Orangewool", "pipliz.crafter", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("OrangeWool", 1));
        }
    }

    [NCAPIType]
    public class OrangeWool : BaseType
    {
        public OrangeWool() : base("OrangeWool", false)
        {
            this.SideAll = "OrangeWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "OrangeWool.png");
        }
    }
}