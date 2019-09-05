using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class bricksslopecornerRecipe : BaseRecipe
    {
        public bricksslopecornerRecipe() : base("bricksslopecornerrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("bricks", 1));
            Result.Add(new InventoryItem("bricksslopecorner", 1));
        }
    }

    [NCAPIType]
    public class bricksslopecorner : DecorativeType
    {
        public bricksslopecorner() : base("bricks", "slopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "bricksslopecorner.png"))
        {
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
            this.SideAll = "bricks";
        }
    }

    [NCAPIType]
    public class bricksslopecornerXMinus : DecorativeTypeXMinus
    {
        public bricksslopecornerXMinus() : base("bricks", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx-");
        }
    }

    [NCAPIType]
    public class bricksslopecornerXPlus : DecorativeTypeXPlus
    {
        public bricksslopecornerXPlus() : base("bricks", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx+");
        }
    }

    [NCAPIType]
    public class bricksslopecornerZMinus : DecorativeTypeZMinus
    {
        public bricksslopecornerZMinus() : base("bricks", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz-");
        }
    }

    [NCAPIType]
    public class bricksslopecornerZPlus : DecorativeTypeZPlus
    {
        public bricksslopecornerZPlus() : base("bricks", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz+");
        }
    }
}