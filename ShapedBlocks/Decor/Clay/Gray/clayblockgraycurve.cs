using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgraycurveRecipe : BaseRecipe
    {
        public clayblockgraycurveRecipe() : base("clayblockgraycurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgraycurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockgraycurve : DecorativeType
    {
        public clayblockgraycurve() : base("clayblockgray", "curve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgraycurve.png"))
        {
            this.SideAll = "clayblockgray";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgraycurveXMinus : DecorativeTypeXMinus
    {
        public clayblockgraycurveXMinus() : base("clayblockgray", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex-");
        }
    }

    [NCAPIType]
    public class clayblockgraycurveXPlus : DecorativeTypeXPlus
    {
        public clayblockgraycurveXPlus() : base("clayblockgray", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex+");
        }
    }

    [NCAPIType]
    public class clayblockgraycurveZMinus : DecorativeTypeZMinus
    {
        public clayblockgraycurveZMinus() : base("clayblockgray", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez-");
        }
    }

    [NCAPIType]
    public class clayblockgraycurveZPlus : DecorativeTypeZPlus
    {
        public clayblockgraycurveZPlus() : base("clayblockgray", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez+");
        }
    }
}