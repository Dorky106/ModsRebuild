using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class brickscurverotatedRecipe : BaseRecipe
    {
        public brickscurverotatedRecipe() : base("brickscurverotatedrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("bricks", 1));
            Result.Add(new InventoryItem("brickscurverotated", 1));
        }
    }

    [NCAPIType]
    public class brickscurverotated : DecorativeType
    {
        public brickscurverotated() : base("bricks", "curverotated",
            Utilities.MultiCombine(Entry.ModIconDirectory, "brickscurverotated.png"))
        {
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
            this.SideAll = "bricks";
        }
    }

    [NCAPIType]
    public class brickscurverotatedXMinus : DecorativeTypeXMinus
    {
        public brickscurverotatedXMinus() : base("bricks", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx-");
        }
    }

    [NCAPIType]
    public class brickscurverotatedXPlus : DecorativeTypeXPlus
    {
        public brickscurverotatedXPlus() : base("bricks", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx+");
        }
    }

    [NCAPIType]
    public class brickscurverotatedZMinus : DecorativeTypeZMinus
    {
        public brickscurverotatedZMinus() : base("bricks", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz-");
        }
    }

    [NCAPIType]
    public class brickscurverotatedZPlus : DecorativeTypeZPlus
    {
        public brickscurverotatedZPlus() : base("bricks", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz+");
        }
    }
}