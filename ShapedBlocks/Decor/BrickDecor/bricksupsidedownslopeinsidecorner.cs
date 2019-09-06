using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class bricksupsidedownslopeinsidecornerRecipe : BaseRecipe
    {
        public bricksupsidedownslopeinsidecornerRecipe() : base("bricksupsidedownslopeinsidecornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("bricks", 1));
            Result.Add(new InventoryItem("bricksupsidedownslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class bricksupsidedownslopeinsidecorner : DecorativeType
    {
        public bricksupsidedownslopeinsidecorner() : base("bricks", "upsidedownslopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "bricksupsidedownslopeinsidecorner.png"))
        {
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
            this.SideAll = "bricks";
        }
    }

    [NCAPIType]
    public class bricksupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public bricksupsidedownslopeinsidecornerXMinus() : base("bricks", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class bricksupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public bricksupsidedownslopeinsidecornerXPlus() : base("bricks", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class bricksupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public bricksupsidedownslopeinsidecornerZMinus() : base("bricks", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class bricksupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public bricksupsidedownslopeinsidecornerZPlus() : base("bricks", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz+");
        }
    }
}