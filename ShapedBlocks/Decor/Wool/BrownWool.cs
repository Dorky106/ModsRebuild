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
    public class BrownWoolText : BaseTexture
    {
        public BrownWoolText() : base("BrownWoolText",
            Path.Combine(Entry.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_brown.png")).Replace("\\", "/")
        )
        { }
    }

    [NCAPIRecipe]
    public class BrownWoolRecipe : BaseRecipe
    {
        public BrownWoolRecipe() : base("Test.Brownwool", "pipliz.crafter", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("BrownWool", 1));
        }
    }

    [NCAPIType]
    public class BrownWool : BaseType
    {
        public BrownWool() : base("BrownWool", false)
        {
            this.SideAll = "BrownWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "BrownWool.png");
        }
    }
}