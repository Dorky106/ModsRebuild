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
    public class GreenWoolText : BaseTexture
    {
        public GreenWoolText() : base("GreenWoolText",
            Path.Combine(Entry.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_green.png")).Replace("\\", "/")
        )
        { }
    }

    [NCAPIRecipe]
    public class GreenWoolRecipe : BaseRecipe
    {
        public GreenWoolRecipe() : base("Test.Greenwool", "pipliz.crafter", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("GreenWool", 1));
        }
    }

    [NCAPIType]
    public class GreenWool : BaseType
    {
        public GreenWool() : base("GreenWool", false)
        {
            this.SideAll = "GreenWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "GreenWool.png");
        }
    }
}