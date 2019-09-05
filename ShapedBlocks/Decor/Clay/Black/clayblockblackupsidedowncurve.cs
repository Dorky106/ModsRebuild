using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblackupsidedowncurveRecipe : BaseRecipe
    {
        public clayblockblackupsidedowncurveRecipe() : base("clayblockblackupsidedowncurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblackupsidedowncurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedowncurve : DecorativeType
    {
        public clayblockblackupsidedowncurve() : base("clayblockblack", "upsidedowncurve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblackupsidedowncurve.png"))
        {
            this.SideAll = "clayblockblack";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedowncurveXMinus : DecorativeTypeXMinus
    {
        public clayblockblackupsidedowncurveXMinus() : base("clayblockblack", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex-");
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedowncurveXPlus : DecorativeTypeXPlus
    {
        public clayblockblackupsidedowncurveXPlus() : base("clayblockblack", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex+");
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedowncurveZMinus : DecorativeTypeZMinus
    {
        public clayblockblackupsidedowncurveZMinus() : base("clayblockblack", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez-");
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedowncurveZPlus : DecorativeTypeZPlus
    {
        public clayblockblackupsidedowncurveZPlus() : base("clayblockblack", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez+");
        }
    }
}