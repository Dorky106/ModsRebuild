using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockredcurveRecipe : BaseRecipe
    {
        public clayblockredcurveRecipe() : base("clayblockredcurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockredcurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockredcurve : DecorativeType
    {
        public clayblockredcurve() : base("clayblockred", "curve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockredcurve.png"))
        {
            this.SideAll = "clayblockred";
        }
    }

    [NCAPIType]
    public class clayblockredcurveXMinus : DecorativeTypeXMinus
    {
        public clayblockredcurveXMinus() : base("clayblockred", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex-");
        }
    }

    [NCAPIType]
    public class clayblockredcurveXPlus : DecorativeTypeXPlus
    {
        public clayblockredcurveXPlus() : base("clayblockred", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex+");
        }
    }

    [NCAPIType]
    public class clayblockredcurveZMinus : DecorativeTypeZMinus
    {
        public clayblockredcurveZMinus() : base("clayblockred", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez-");
        }
    }

    [NCAPIType]
    public class clayblockredcurveZPlus : DecorativeTypeZPlus
    {
        public clayblockredcurveZPlus() : base("clayblockred", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez+");
        }
    }
}