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
    public class PurpleWoolText : BaseTexture
    {
        public PurpleWoolText() : base("PurpleWoolText",
            Path.Combine(Entry.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_purple.png")).Replace("\\", "/")
        )
        { }
    }

    [NCAPIRecipe]
    public class PurpleWoolRecipe : BaseRecipe
    {
        public PurpleWoolRecipe() : base("Test.Purplewool", "pipliz.crafter", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("PurpleWool", 1));
        }
    }

    [NCAPIType]
    public class PurpleWool : BaseType
    {
        public PurpleWool() : base("PurpleWool", false)
        {
            this.SideAll = "PurpleWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "PurpleWool.png");
        }
    }
}