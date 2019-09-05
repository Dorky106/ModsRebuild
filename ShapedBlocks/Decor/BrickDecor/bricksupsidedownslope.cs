using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using System.Collections.Generic;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class bricksupsidedownslopeRecipe : BaseRecipe
    {
        public bricksupsidedownslopeRecipe() : base("bricksupsidedownsloperecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("bricks", 1));
            Result.Add(new InventoryItem("bricksupsidedownslope", 1));
        }
    }

    [NCAPIType]
    public class bricksupsidedownslope : DecorativeType
    {
        public bricksupsidedownslope() : base("bricks", "upsidedownslope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "bricksupsidedownslope.png"))
        {
            this.Categories = new List<string> { "decorative" };
            this.SideAll = "bricks";
        }
    }

    [NCAPIType]
    public class bricksupsidedownslopeXMinus : DecorativeTypeXMinus
    {
        public bricksupsidedownslopeXMinus() : base("bricks", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex-");
        }
    }

    [NCAPIType]
    public class bricksupsidedownslopeXPlus : DecorativeTypeXPlus
    {
        public bricksupsidedownslopeXPlus() : base("bricks", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex+");
        }
    }

    [NCAPIType]
    public class bricksupsidedownslopeZMinus : DecorativeTypeZMinus
    {
        public bricksupsidedownslopeZMinus() : base("bricks", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez-");
        }
    }

    [NCAPIType]
    public class bricksupsidedownslopeZPlus : DecorativeTypeZPlus
    {
        public bricksupsidedownslopeZPlus() : base("bricks", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez+");
        }
    }
}