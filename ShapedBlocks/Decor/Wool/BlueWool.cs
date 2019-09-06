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
    public class BlueWoolText : BaseTexture
    {
        public BlueWoolText() : base("BlueWoolText",
            Path.Combine(Entry.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_blue.png")).Replace("\\", "/")
        )
        { }
    }

    [NCAPIRecipe]
    public class BlueWoolRecipe : BaseRecipe
    {
        public BlueWoolRecipe() : base("Test.Bluewool", "pipliz.crafter", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("BlueWool", 1));
        }
    }

    [NCAPIType]
    public class BlueWool : BaseType
    {
        public BlueWool() : base("BlueWool", false)
        {
            this.SideAll = "BlueWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "BlueWool.png");
        }
    }
}