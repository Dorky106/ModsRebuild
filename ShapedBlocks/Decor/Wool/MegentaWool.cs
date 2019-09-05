using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Wool
{
    [NCAPIRecipe]
    public class MegentaWoolRecipe : BaseRecipe
    {
        public MegentaWoolRecipe() : base("Test.Megentawool", "pipliz.crafter", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("MegentaWool", 1));
        }
    }

    [NCAPIType]
    public class MegentaWool : BaseType
    {
        public MegentaWool() : base("MegentaWool", false)
        {
            this.SideAll = "MegentaWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "MegentaWool.png");
        }
    }
}