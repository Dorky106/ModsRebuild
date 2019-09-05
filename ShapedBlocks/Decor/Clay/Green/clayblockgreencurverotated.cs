using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgreencurverotatedRecipe : BaseRecipe
    {
        public clayblockgreencurverotatedRecipe() : base("clayblockgreencurverotatedrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgreencurverotated", 1));
        }
    }

    [NCAPIType]
    public class clayblockgreencurverotated : DecorativeType
    {
        public clayblockgreencurverotated() : base("clayblockgreen", "curverotated",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgreencurverotated.png"))
        {
            this.SideAll = "clayblockgreen";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgreencurverotatedXMinus : DecorativeTypeXMinus
    {
        public clayblockgreencurverotatedXMinus() : base("clayblockgreen", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx-");
        }
    }

    [NCAPIType]
    public class clayblockgreencurverotatedXPlus : DecorativeTypeXPlus
    {
        public clayblockgreencurverotatedXPlus() : base("clayblockgreen", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx+");
        }
    }

    [NCAPIType]
    public class clayblockgreencurverotatedZMinus : DecorativeTypeZMinus
    {
        public clayblockgreencurverotatedZMinus() : base("clayblockgreen", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz-");
        }
    }

    [NCAPIType]
    public class clayblockgreencurverotatedZPlus : DecorativeTypeZPlus
    {
        public clayblockgreencurverotatedZPlus() : base("clayblockgreen", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz+");
        }
    }
}