using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class bricksslopeRecipe : BaseRecipe
    {
        public bricksslopeRecipe() : base("brickssloperecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("bricks", 1));
            Result.Add(new InventoryItem("bricksslope", 1));
        }
    }

    [NCAPIType]
    public class bricksslope : DecorativeType
    {
        public bricksslope() : base("bricks", "slope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "bricksslope.png"))
        {
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
            this.SideAll = "bricks";
        }
    }

    [NCAPIType]
    public class bricksslopeXMinus : DecorativeTypeXMinus
    {
        public bricksslopeXMinus() : base("bricks", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class bricksslopeXPlus : DecorativeTypeXPlus
    {
        public bricksslopeXPlus() : base("bricks", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class bricksslopeZMinus : DecorativeTypeZMinus
    {
        public bricksslopeZMinus() : base("bricks", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class bricksslopeZPlus : DecorativeTypeZPlus
    {
        public bricksslopeZPlus() : base("bricks", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}