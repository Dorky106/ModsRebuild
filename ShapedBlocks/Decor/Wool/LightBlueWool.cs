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
    public class LightBlueWoolText : BaseTexture
    {
        public LightBlueWoolText() : base("LightBlueWoolText",
            Path.Combine(Entry.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_light_blue.png")).Replace("\\", "/")
        )
        { }
    }

    [NCAPIRecipe]
    public class LightBlueWoolRecipe : BaseRecipe
    {
        public LightBlueWoolRecipe() : base("Test.LightBluewool", "pipliz.crafter", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("LightBlueWool", 1));
        }
    }

    [NCAPIType]
    public class LightBlueWool : BaseType
    {
        public LightBlueWool() : base("LightBlueWool", false)
        {
            this.SideAll = "LightBlueWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "LightBlueWool.png");
        }
    }
}