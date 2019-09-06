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
    public class MegentaWoolText : BaseTexture
    {
        public MegentaWoolText() : base("MegentaWoolText",
            Path.Combine(Entry.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_magenta.png")).Replace("\\", "/")
        )
        { }
    }

    [NCAPIRecipe]
    public class MegentaWoolRecipe : BaseRecipe
    {
        public MegentaWoolRecipe() : base("Test.Megentawool", "pipliz.crafter", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("MegentaWool", 1));
        }
    }

    [NCAPIType]
    public class MegentaWool : BaseType
    {
        public MegentaWool() : base("MegentaWool", false)
        {
            this.SideAll = "MegentaWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "MegentaWool.png");
        }
    }
}