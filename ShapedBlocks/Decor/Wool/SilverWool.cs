using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using System.Collections.Generic;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Wool
{
    [NCAPIType]
    public class SilverWool : BaseType
    {
        public SilverWool() : base("SilverWool", true)
        {
            this.SideAll = "SilverWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "SilverWool.png");
        }

        public override List<BaseRecipe> AddRecipes()
        {
            List<BaseRecipe> recipes = new List<BaseRecipe>()
            {
                new BaseRecipe("ShapedBlocks.SilverWool", "pipliz.crafter", false, 10, 1)
                {
                    Requirements = new List<InventoryItem>()
                    {
                        new InventoryItem("flax", 1)
                    },
                    Result = new List<InventoryItem>()
                    {
                        new InventoryItem("SilverWool", 1)
                    }
                }
            };

            return recipes;
        }
    }
}