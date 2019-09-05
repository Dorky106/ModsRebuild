using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Wool
{
    [NCAPIRecipe]
    public class LightBlueWoolRecipe : BaseRecipe
    {
        public LightBlueWoolRecipe() : base("Test.LightBluewool", "pipliz.crafter", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("LightBlueWool", 1));
        }
    }

    [NCAPIType]
    public class LightBlueWool : BaseType
    {
        public LightBlueWool() : base("LightBlueWool", false)
        {
            this.SideAll = "LightBlueWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "LightBlueWool.png");
        }
    }
}