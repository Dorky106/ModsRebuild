using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpinkcurveRecipe : BaseRecipe
    {
        public clayblockpinkcurveRecipe() : base("clayblockpinkcurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpinkcurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockpinkcurve : DecorativeType
    {
        public clayblockpinkcurve() : base("clayblockpink", "curve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpinkcurve.png"))
        {
            this.SideAll = "clayblockpink";
        }
    }

    [NCAPIType]
    public class clayblockpinkcurveXMinus : DecorativeTypeXMinus
    {
        public clayblockpinkcurveXMinus() : base("clayblockpink", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex-");
        }
    }

    [NCAPIType]
    public class clayblockpinkcurveXPlus : DecorativeTypeXPlus
    {
        public clayblockpinkcurveXPlus() : base("clayblockpink", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex+");
        }
    }

    [NCAPIType]
    public class clayblockpinkcurveZMinus : DecorativeTypeZMinus
    {
        public clayblockpinkcurveZMinus() : base("clayblockpink", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez-");
        }
    }

    [NCAPIType]
    public class clayblockpinkcurveZPlus : DecorativeTypeZPlus
    {
        public clayblockpinkcurveZPlus() : base("clayblockpink", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez+");
        }
    }
}