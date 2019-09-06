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
    public class PinkWoolText : BaseTexture
    {
        public PinkWoolText() : base("PinkWoolText",
            Path.Combine(Entry.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_pink.png")).Replace("\\", "/")
        )
        { }
    }

    [NCAPIRecipe]
    public class PinkWoolRecipe : BaseRecipe
    {
        public PinkWoolRecipe() : base("Test.Pinkwool", "pipliz.crafter", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("PinkWool", 1));
        }
    }

    [NCAPIType]
    public class PinkWool : BaseType
    {
        public PinkWool() : base("PinkWool", false)
        {
            this.SideAll = "PinkWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "PinkWool.png");
        }
    }
}