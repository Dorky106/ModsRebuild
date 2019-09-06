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
    public class OrangeWoolText : BaseTexture
    {
        public OrangeWoolText() : base("OrangeWoolText",
            Path.Combine(Entry.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_orange.png")).Replace("\\", "/")
        )
        { }
    }

    [NCAPIRecipe]
    public class OrangeWoolRecipe : BaseRecipe
    {
        public OrangeWoolRecipe() : base("Test.Orangewool", "pipliz.crafter", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("OrangeWool", 1));
        }
    }

    [NCAPIType]
    public class OrangeWool : BaseType
    {
        public OrangeWool() : base("OrangeWool", false)
        {
            this.SideAll = "OrangeWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "OrangeWool.png");
        }
    }
}