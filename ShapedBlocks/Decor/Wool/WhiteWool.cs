using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using System.Collections.Generic;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Wool
{
    [NCAPIType]
    public class WhiteWool : BaseType
    {
        public WhiteWool() : base("WhiteWool", true)
        {
            this.SideAll = "WhiteWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "WhiteWool.png");
        }

        public override List<BaseRecipe> AddRecipes()
        {
            List<BaseRecipe> recipes = new List<BaseRecipe>()
            {
                new BaseRecipe("ShapedBlocks.WhiteWool", "pipliz.crafter", false, 10, 1)
                {
                    Requirements = new List<InventoryItem>()
                    {
                        new InventoryItem("flax", 1)
                    },
                    Result = new List<InventoryItem>()
                    {
                        new InventoryItem("WhiteWool", 1)
                    }
                }
            };

            return recipes;
        }
    }
}