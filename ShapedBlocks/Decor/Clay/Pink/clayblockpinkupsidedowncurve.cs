using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpinkupsidedowncurveRecipe : BaseRecipe
    {
        public clayblockpinkupsidedowncurveRecipe() : base("clayblockpinkupsidedowncurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpinkupsidedowncurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedowncurve : DecorativeType
    {
        public clayblockpinkupsidedowncurve() : base("clayblockpink", "upsidedowncurve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpinkupsidedowncurve.png"))
        {
            this.SideAll = "clayblockpink";
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedowncurveXMinus : DecorativeTypeXMinus
    {
        public clayblockpinkupsidedowncurveXMinus() : base("clayblockpink", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex-");
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedowncurveXPlus : DecorativeTypeXPlus
    {
        public clayblockpinkupsidedowncurveXPlus() : base("clayblockpink", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex+");
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedowncurveZMinus : DecorativeTypeZMinus
    {
        public clayblockpinkupsidedowncurveZMinus() : base("clayblockpink", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez-");
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedowncurveZPlus : DecorativeTypeZPlus
    {
        public clayblockpinkupsidedowncurveZPlus() : base("clayblockpink", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez+");
        }
    }
}