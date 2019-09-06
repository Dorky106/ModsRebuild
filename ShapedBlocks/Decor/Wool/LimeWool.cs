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
    public class LimeWoolText : BaseTexture
    {
        public LimeWoolText() : base("LimeWoolText",
            Path.Combine(Entry.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_lime.png")).Replace("\\", "/")
        )
        { }
    }

    [NCAPIRecipe]
    public class LimeWoolRecipe : BaseRecipe
    {
        public LimeWoolRecipe() : base("Test.Limewool", "pipliz.crafter", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("LimeWool", 1));
        }
    }

    [NCAPIType]
    public class LimeWool : BaseType
    {
        public LimeWool() : base("LimeWool", false)
        {
            this.SideAll = "LimeWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "LimeWool.png");
        }
    }
}