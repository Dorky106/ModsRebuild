using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblackcurveRecipe : BaseRecipe
    {
        public clayblockblackcurveRecipe() : base("clayblockblackcurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblackcurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockblackcurve : DecorativeType
    {
        public clayblockblackcurve() : base("clayblockblack", "curve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblackcurve.png"))
        {
            this.SideAll = "clayblockblack";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblackcurveXMinus : DecorativeTypeXMinus
    {
        public clayblockblackcurveXMinus() : base("clayblockblack", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex-");
        }
    }

    [NCAPIType]
    public class clayblockblackcurveXPlus : DecorativeTypeXPlus
    {
        public clayblockblackcurveXPlus() : base("clayblockblack", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex+");
        }
    }

    [NCAPIType]
    public class clayblockblackcurveZMinus : DecorativeTypeZMinus
    {
        public clayblockblackcurveZMinus() : base("clayblockblack", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez-");
        }
    }

    [NCAPIType]
    public class clayblockblackcurveZPlus : DecorativeTypeZPlus
    {
        public clayblockblackcurveZPlus() : base("clayblockblack", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez+");
        }
    }
}