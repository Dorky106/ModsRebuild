using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class bricksfourstepstairsinsidecornerRecipe : BaseRecipe
    {
        public bricksfourstepstairsinsidecornerRecipe() : base("bricksfourstepstairsinsidecornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("bricks", 1));
            Result.Add(new InventoryItem("bricksfourstepstairsinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class bricksfourstepstairsinsidecorner : DecorativeType
    {
        public bricksfourstepstairsinsidecorner() : base("bricks", "fourstepstairsinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "bricksfourstepstairsinsidecorner.png"))
        {
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
            this.SideAll = "bricks";
        }
    }

    [NCAPIType]
    public class bricksfourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
    {
        public bricksfourstepstairsinsidecornerXMinus() : base("bricks", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx-");
        }
    }

    [NCAPIType]
    public class bricksfourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
    {
        public bricksfourstepstairsinsidecornerXPlus() : base("bricks", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx+");
        }
    }

    [NCAPIType]
    public class bricksfourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
    {
        public bricksfourstepstairsinsidecornerZMinus() : base("bricks", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz-");
        }
    }

    [NCAPIType]
    public class bricksfourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
    {
        public bricksfourstepstairsinsidecornerZPlus() : base("bricks", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz+");
        }
    }
}