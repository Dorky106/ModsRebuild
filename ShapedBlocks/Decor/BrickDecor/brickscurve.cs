using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class brickscurveRecipe : BaseRecipe
    {
        public brickscurveRecipe() : base("brickscurverecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("bricks", 1));
            Result.Add(new InventoryItem("brickscurve", 1));
        }
    }

    [NCAPIType]
    public class brickscurve : DecorativeType
    {
        public brickscurve() : base("bricks", "curve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "brickscurve.png"))
        {
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
            this.SideAll = "bricks";
        }
    }

    [NCAPIType]
    public class brickscurveXMinus : DecorativeTypeXMinus
    {
        public brickscurveXMinus() : base("bricks", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex-");
        }
    }

    [NCAPIType]
    public class brickscurveXPlus : DecorativeTypeXPlus
    {
        public brickscurveXPlus() : base("bricks", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex+");
        }
    }

    [NCAPIType]
    public class brickscurveZMinus : DecorativeTypeZMinus
    {
        public brickscurveZMinus() : base("bricks", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez-");
        }
    }

    [NCAPIType]
    public class brickscurveZPlus : DecorativeTypeZPlus
    {
        public brickscurveZPlus() : base("bricks", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez+");
        }
    }
}