using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgrayupsidedowncurveRecipe : BaseRecipe
    {
        public clayblockgrayupsidedowncurveRecipe() : base("clayblockgrayupsidedowncurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgrayupsidedowncurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedowncurve : DecorativeType
    {
        public clayblockgrayupsidedowncurve() : base("clayblockgray", "upsidedowncurve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgrayupsidedowncurve.png"))
        {
            this.SideAll = "clayblockgray";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedowncurveXMinus : DecorativeTypeXMinus
    {
        public clayblockgrayupsidedowncurveXMinus() : base("clayblockgray", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex-");
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedowncurveXPlus : DecorativeTypeXPlus
    {
        public clayblockgrayupsidedowncurveXPlus() : base("clayblockgray", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex+");
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedowncurveZMinus : DecorativeTypeZMinus
    {
        public clayblockgrayupsidedowncurveZMinus() : base("clayblockgray", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez-");
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedowncurveZPlus : DecorativeTypeZPlus
    {
        public clayblockgrayupsidedowncurveZPlus() : base("clayblockgray", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez+");
        }
    }
}