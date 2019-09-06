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
    public class BlackWoolText : BaseTexture
    {
        public BlackWoolText() : base("BlackWoolText",
            Path.Combine(Entry.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_black.png")).Replace("\\", "/")
        )
        { }
    }

    [NCAPIRecipe]
    public class BlackWoolRecipe : BaseRecipe
    {
        public BlackWoolRecipe() : base("Test.Blackwool", "pipliz.crafter", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("BlackWool", 1));
        }
    }

    [NCAPIType]
    public class BlackWool : BaseType
    {
        public BlackWool() : base("BlackWool", false)
        {
            this.SideAll = "BlackWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "BlackWool.png");
        }
    }
}