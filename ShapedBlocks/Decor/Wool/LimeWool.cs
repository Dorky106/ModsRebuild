using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Wool
{
    [NCAPIRecipe]
    public class LimeWoolRecipe : BaseRecipe
    {
        public LimeWoolRecipe() : base("Test.Limewool", "pipliz.crafter", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("LimeWool", 1));
        }
    }

    [NCAPIType]
    public class LimeWool : BaseType
    {
        public LimeWool() : base("LimeWool", false)
        {
            this.SideAll = "LimeWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "LimeWool.png");
        }
    }
}