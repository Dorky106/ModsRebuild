using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class ClayblockwhiteupsidedowncurveRecipe : BaseRecipe
    {
        public ClayblockwhiteupsidedowncurveRecipe() : base("clayblockwhiteupsidedowncurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockwhiteupsidedowncurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedowncurve : DecorativeType
    {
        public clayblockwhiteupsidedowncurve() : base("clayblockwhite", "upsidedowncurve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockwhiteupsidedowncurve.png"))
        {
            this.SideAll = "clayblockwhite";
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedowncurveXMinus : DecorativeTypeXMinus
    {
        public clayblockwhiteupsidedowncurveXMinus() : base("clayblockwhite", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex-");
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedowncurveXPlus : DecorativeTypeXPlus
    {
        public clayblockwhiteupsidedowncurveXPlus() : base("clayblockwhite", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex+");
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedowncurveZMinus : DecorativeTypeZMinus
    {
        public clayblockwhiteupsidedowncurveZMinus() : base("clayblockwhite", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez-");
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedowncurveZPlus : DecorativeTypeZPlus
    {
        public clayblockwhiteupsidedowncurveZPlus() : base("clayblockwhite", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez+");
        }
    }
}