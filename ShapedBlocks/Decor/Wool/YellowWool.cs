using System.Collections.Generic;
using System.IO;
using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Textures;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Textures.TextureManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Wool
{
    [NCAPITexture]
    public class YellowWoolText : BaseTexture
    {
        public YellowWoolText() : base("YellowWoolText",
            Path.Combine(Entry.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_yellow.png")).Replace("\\", "/")
        )
        { }
    }

    [NCAPIType]
    public class YellowWool : BaseType
    {
        public YellowWool() : base("YellowWool", true)
        {
            this.SideAll = "YellowWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "YellowWool.png");
        }

        public override List<BaseRecipe> AddRecipes()
        {
            List<BaseRecipe> recipes = new List<BaseRecipe>()
            {
                new BaseRecipe("ShapedBlocks.YellowWool", "pipliz.crafter", false, 10, 1)
                {
                    Requirements = new List<InventoryItem>()
                    {
                        new InventoryItem("flax", 1)
                    },
                    Result = new List<InventoryItem>()
                    {
                        new InventoryItem("YellowWool", 1)
                    }
                }
            };

            return recipes;
        }
    }
}