using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbluecurveRecipe : BaseRecipe
    {
        public clayblockbluecurveRecipe() : base("clayblockbluecurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbluecurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockbluecurve : DecorativeType
    {
        public clayblockbluecurve() : base("clayblockblue", "curve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbluecurve.png"))
        {
            this.SideAll = "clayblockblue";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbluecurveXMinus : DecorativeTypeXMinus
    {
        public clayblockbluecurveXMinus() : base("clayblockblue", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex-");
        }
    }

    [NCAPIType]
    public class clayblockbluecurveXPlus : DecorativeTypeXPlus
    {
        public clayblockbluecurveXPlus() : base("clayblockblue", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex+");
        }
    }

    [NCAPIType]
    public class clayblockbluecurveZMinus : DecorativeTypeZMinus
    {
        public clayblockbluecurveZMinus() : base("clayblockblue", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez-");
        }
    }

    [NCAPIType]
    public class clayblockbluecurveZPlus : DecorativeTypeZPlus
    {
        public clayblockbluecurveZPlus() : base("clayblockblue", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez+");
        }
    }
}