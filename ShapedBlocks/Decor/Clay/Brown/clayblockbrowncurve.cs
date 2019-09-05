using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbrowncurveRecipe : BaseRecipe
    {
        public clayblockbrowncurveRecipe() : base("clayblockbrowncurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbrowncurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockbrowncurve : DecorativeType
    {
        public clayblockbrowncurve() : base("clayblockbrown", "curve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbrowncurve.png"))
        {
            this.SideAll = "clayblockbrown";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbrowncurveXMinus : DecorativeTypeXMinus
    {
        public clayblockbrowncurveXMinus() : base("clayblockbrown", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex-");
        }
    }

    [NCAPIType]
    public class clayblockbrowncurveXPlus : DecorativeTypeXPlus
    {
        public clayblockbrowncurveXPlus() : base("clayblockbrown", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex+");
        }
    }

    [NCAPIType]
    public class clayblockbrowncurveZMinus : DecorativeTypeZMinus
    {
        public clayblockbrowncurveZMinus() : base("clayblockbrown", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez-");
        }
    }

    [NCAPIType]
    public class clayblockbrowncurveZPlus : DecorativeTypeZPlus
    {
        public clayblockbrowncurveZPlus() : base("clayblockbrown", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez+");
        }
    }
}