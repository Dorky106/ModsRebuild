using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Textures;
using PhentrixGames.NewColonyAPI.Types;
using System.IO;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Textures.TextureManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.RiseoftheNewColonies.NewBlocks
{
    [NCAPITexture]
    public class BoardedDirtTexture : BaseTexture
    {
        public BoardedDirtTexture() : base("boardeddirt", Path.Combine(Entry.ModMaterialsDirectory, "albedo", "boardeddirt.png").Replace("\\", "/"))
        { }
    }

    [NCAPIRecipe]
    public class BoardedDirtRecipe : BaseRecipe
    {
        public BoardedDirtRecipe() : base("boardeddirtreciped")
        {
            Requirements.Add(new InventoryItem("planks", 2));
            Requirements.Add(new InventoryItem("dirt", 3));
            Result.Add(new InventoryItem("boardeddirt", 2));
        }
    }

    [NCAPIType]
    public class BoardedDirt : BaseType
    {
        public BoardedDirt() : base("boardeddirt", false)
        {
            this.IsFertile = true;
            this.SideAll = "planks";
            this.SideYPlus = "boardeddirt";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "boardeddirt.png");
        }
    }
}