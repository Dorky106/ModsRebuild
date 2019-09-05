using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Textures;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Textures.TextureManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks
{
    [NCAPITexture]
    public class WoodCarver : BaseTexture
    {
        public WoodCarver() : base("woodcarver",
            Utilities.MultiCombine(Entry.ModMaterialsDirectory, "albedo", "woodcarver.png"))
        { }
    }

    [NCAPIType]
    public class WoodCarvingStation : BaseType
    {
        public WoodCarvingStation() : base("Wood Carving Station", true)
        {
            this.SideAll = "planks";
            this.SideYPlus = "woodcarver";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "woodcarver.png");
        }
    }

    [NCAPIRecipe]
    public class WoodCarverRecipe : BaseRecipe
    {
        public WoodCarverRecipe() : base("phentrixgames.window", "pipliz.crafter", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("planks", 20));
            Requirements.Add(new InventoryItem("ironingot", 2));
            Result.Add(new InventoryItem("Wood Carving Station", 1));
        }
    }
}