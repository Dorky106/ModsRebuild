using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpurpleupsidedowncurveRecipe : BaseRecipe
    {
        public clayblockpurpleupsidedowncurveRecipe() : base("clayblockpurpleupsidedowncurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpurpleupsidedowncurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedowncurve : DecorativeType
    {
        public clayblockpurpleupsidedowncurve() : base("clayblockpurple", "upsidedowncurve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpurpleupsidedowncurve.png"))
        {
            this.SideAll = "clayblockpurple";
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedowncurveXMinus : DecorativeTypeXMinus
    {
        public clayblockpurpleupsidedowncurveXMinus() : base("clayblockpurple", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex-");
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedowncurveXPlus : DecorativeTypeXPlus
    {
        public clayblockpurpleupsidedowncurveXPlus() : base("clayblockpurple", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex+");
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedowncurveZMinus : DecorativeTypeZMinus
    {
        public clayblockpurpleupsidedowncurveZMinus() : base("clayblockpurple", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez-");
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedowncurveZPlus : DecorativeTypeZPlus
    {
        public clayblockpurpleupsidedowncurveZPlus() : base("clayblockpurple", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez+");
        }
    }
}