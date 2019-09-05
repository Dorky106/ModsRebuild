using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockwhitecurveRecipe : BaseRecipe
    {
        public clayblockwhitecurveRecipe() : base("clayblockwhitecurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockwhitecurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockwhitecurve : DecorativeType
    {
        public clayblockwhitecurve() : base("clayblockwhite", "curve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockwhitecurve.png"))
        {
            this.SideAll = "clayblockwhite";
        }
    }

    [NCAPIType]
    public class clayblockwhitecurveXMinus : DecorativeTypeXMinus
    {
        public clayblockwhitecurveXMinus() : base("clayblockwhite", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex-");
        }
    }

    [NCAPIType]
    public class clayblockwhitecurveXPlus : DecorativeTypeXPlus
    {
        public clayblockwhitecurveXPlus() : base("clayblockwhite", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex+");
        }
    }

    [NCAPIType]
    public class clayblockwhitecurveZMinus : DecorativeTypeZMinus
    {
        public clayblockwhitecurveZMinus() : base("clayblockwhite", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez-");
        }
    }

    [NCAPIType]
    public class clayblockwhitecurveZPlus : DecorativeTypeZPlus
    {
        public clayblockwhitecurveZPlus() : base("clayblockwhite", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez+");
        }
    }
}