using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Textures;
using PhentrixGames.NewColonyAPI.Types;
using System.IO;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Textures.TextureManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Wool
{
    [NCAPITexture]
    public class GrayWoolText : BaseTexture
    {
        public GrayWoolText() : base("GrayWoolText",
            Path.Combine(Entry.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_gray.png")).Replace("\\", "/")
        )
        { }
    }

    [NCAPIRecipe]
    public class GrayWoolRecipe : BaseRecipe
    {
        public GrayWoolRecipe() : base("Test.Graywool", "pipliz.crafter", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("GrayWool", 1));
        }
    }

    [NCAPIType]
    public class GrayWool : BaseType
    {
        public GrayWool() : base("GrayWool", false)
        {
            this.SideAll = "GrayWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "GrayWool.png");
        }
    }
}