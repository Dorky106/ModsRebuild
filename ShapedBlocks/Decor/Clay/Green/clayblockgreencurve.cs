using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgreencurveRecipe : BaseRecipe
    {
        public clayblockgreencurveRecipe() : base("clayblockgreencurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgreencurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockgreencurve : DecorativeType
    {
        public clayblockgreencurve() : base("clayblockgreen", "curve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgreencurve.png"))
        {
            this.SideAll = "clayblockgreen";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgreencurveXMinus : DecorativeTypeXMinus
    {
        public clayblockgreencurveXMinus() : base("clayblockgreen", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex-");
        }
    }

    [NCAPIType]
    public class clayblockgreencurveXPlus : DecorativeTypeXPlus
    {
        public clayblockgreencurveXPlus() : base("clayblockgreen", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex+");
        }
    }

    [NCAPIType]
    public class clayblockgreencurveZMinus : DecorativeTypeZMinus
    {
        public clayblockgreencurveZMinus() : base("clayblockgreen", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez-");
        }
    }

    [NCAPIType]
    public class clayblockgreencurveZPlus : DecorativeTypeZPlus
    {
        public clayblockgreencurveZPlus() : base("clayblockgreen", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez+");
        }
    }
}