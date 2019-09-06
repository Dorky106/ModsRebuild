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
    public class CyanWoolText : BaseTexture
    {
        public CyanWoolText() : base("CyanWoolText",
            Path.Combine(Entry.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_cyan.png")).Replace("\\", "/")
        )
        { }
    }

    [NCAPIRecipe]
    public class CyanWoolRecipe : BaseRecipe
    {
        public CyanWoolRecipe() : base("Test.Cyanwool", "pipliz.crafter", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("CyanWool", 1));
        }
    }

    [NCAPIType]
    public class CyanWool : BaseType
    {
        public CyanWool() : base("CyanWool", false)
        {
            this.SideAll = "CyanWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "CyanWool.png");
        }
    }
}