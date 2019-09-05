using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class bricksslopeinsidecornerRecipe : BaseRecipe
    {
        public bricksslopeinsidecornerRecipe() : base("bricksslopeinsidecornerrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("bricks", 1));
            Result.Add(new InventoryItem("bricksslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class bricksslopeinsidecorner : DecorativeType
    {
        public bricksslopeinsidecorner() : base("bricks", "slopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "bricksslopeinsidecorner.png"))
        {
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
            this.SideAll = "bricks";
        }
    }

    [NCAPIType]
    public class bricksslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public bricksslopeinsidecornerXMinus() : base("bricks", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class bricksslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public bricksslopeinsidecornerXPlus() : base("bricks", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class bricksslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public bricksslopeinsidecornerZMinus() : base("bricks", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class bricksslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public bricksslopeinsidecornerZPlus() : base("bricks", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz+");
        }
    }
}