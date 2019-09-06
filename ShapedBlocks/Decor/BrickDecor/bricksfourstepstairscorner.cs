using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class bricksfourstepstairscornerRecipe : BaseRecipe
    {
        public bricksfourstepstairscornerRecipe() : base("bricksfourstepstairscornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("bricks", 1));
            Result.Add(new InventoryItem("bricksfourstepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class bricksfourstepstairscorner : DecorativeType
    {
        public bricksfourstepstairscorner() : base("bricks", "fourstepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "bricksfourstepstairscorner.png"))
        {
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
            this.SideAll = "bricks";
        }
    }

    [NCAPIType]
    public class bricksfourstepstairscornerXMinus : DecorativeTypeXMinus
    {
        public bricksfourstepstairscornerXMinus() : base("bricks", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx-");
        }
    }

    [NCAPIType]
    public class bricksfourstepstairscornerXPlus : DecorativeTypeXPlus
    {
        public bricksfourstepstairscornerXPlus() : base("bricks", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx+");
        }
    }

    [NCAPIType]
    public class bricksfourstepstairscornerZMinus : DecorativeTypeZMinus
    {
        public bricksfourstepstairscornerZMinus() : base("bricks", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz-");
        }
    }

    [NCAPIType]
    public class bricksfourstepstairscornerZPlus : DecorativeTypeZPlus
    {
        public bricksfourstepstairscornerZPlus() : base("bricks", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz+");
        }
    }
}