using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Textures;
using PhentrixGames.NewColonyAPI.Types;
using System.Collections.Generic;
using System.IO;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Textures.TextureManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Wool
{
    [NCAPITexture]
    public class SilverWoolText : BaseTexture
    {
        public SilverWoolText() : base("SilverWoolText",
            Path.Combine(Entry.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_silver.png")).Replace("\\", "/")
        )
        { }
    }

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