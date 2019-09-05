using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Wool
{
    [NCAPIRecipe]
    public class RedWoolRecipe : BaseRecipe
    {
        public RedWoolRecipe() : base("Test.Redwool", "pipliz.crafter", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("RedWool", 1));
        }
    }

    [NCAPIType]
    public class RedWool : BaseType
    {
        public RedWool() : base("RedWool", true)
        {
            this.SideAll = "RedWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "RedWool.png");
        }
    }
}