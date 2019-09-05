using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpurplecurveRecipe : BaseRecipe
    {
        public clayblockpurplecurveRecipe() : base("clayblockpurplecurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpurplecurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockpurplecurve : DecorativeType
    {
        public clayblockpurplecurve() : base("clayblockpurple", "curve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpurplecurve.png"))
        {
            this.SideAll = "clayblockpurple";
        }
    }

    [NCAPIType]
    public class clayblockpurplecurveXMinus : DecorativeTypeXMinus
    {
        public clayblockpurplecurveXMinus() : base("clayblockpurple", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex-");
        }
    }

    [NCAPIType]
    public class clayblockpurplecurveXPlus : DecorativeTypeXPlus
    {
        public clayblockpurplecurveXPlus() : base("clayblockpurple", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex+");
        }
    }

    [NCAPIType]
    public class clayblockpurplecurveZMinus : DecorativeTypeZMinus
    {
        public clayblockpurplecurveZMinus() : base("clayblockpurple", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez-");
        }
    }

    [NCAPIType]
    public class clayblockpurplecurveZPlus : DecorativeTypeZPlus
    {
        public clayblockpurplecurveZPlus() : base("clayblockpurple", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez+");
        }
    }
}