using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockupsidedowncurveRecipe : BaseRecipe
    {
        public clayblockupsidedowncurveRecipe() : base("clayblockupsidedowncurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockupsidedowncurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockupsidedowncurve : DecorativeType
    {
        public clayblockupsidedowncurve() : base("clayblock", "upsidedowncurve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockupsidedowncurve.png"))
        {
            this.SideAll = "clayblock";
        }
    }

    [NCAPIType]
    public class clayblockupsidedowncurveXMinus : DecorativeTypeXMinus
    {
        public clayblockupsidedowncurveXMinus() : base("clayblock", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex-");
        }
    }

    [NCAPIType]
    public class clayblockupsidedowncurveXPlus : DecorativeTypeXPlus
    {
        public clayblockupsidedowncurveXPlus() : base("clayblock", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex+");
        }
    }

    [NCAPIType]
    public class clayblockupsidedowncurveZMinus : DecorativeTypeZMinus
    {
        public clayblockupsidedowncurveZMinus() : base("clayblock", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez-");
        }
    }

    [NCAPIType]
    public class clayblockupsidedowncurveZPlus : DecorativeTypeZPlus
    {
        public clayblockupsidedowncurveZPlus() : base("clayblock", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez+");
        }
    }
}