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
    public class RedWoolText : BaseTexture
    {
        public RedWoolText() : base("RedWoolText",
            Path.Combine(Entry.ModMaterialsDirectory, Path.Combine("Wool", "wool_colored_red.png")).Replace("\\", "/")
        )
        { }
    }

    [NCAPIRecipe]
    public class RedWoolRecipe : BaseRecipe
    {
        public RedWoolRecipe() : base("Test.Redwool", "pipliz.crafter", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("flax", 1));
            Result.Add(new InventoryItem("RedWool", 1));
        }
    }

    [NCAPIType]
    public class RedWool : BaseType
    {
        public RedWool() : base("RedWool", false)
        {
            this.SideAll = "RedWoolText";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "Wool", "RedWool.png");
        }
    }
}