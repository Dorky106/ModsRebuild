using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockmagentaupsidedowncurveRecipe : BaseRecipe
    {
        public clayblockmagentaupsidedowncurveRecipe() : base("clayblockmagentaupsidedowncurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockmagentaupsidedowncurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedowncurve : DecorativeType
    {
        public clayblockmagentaupsidedowncurve() : base("clayblockmagenta", "upsidedowncurve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockmagentaupsidedowncurve.png"))
        {
            this.SideAll = "clayblockmagenta";
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedowncurveXMinus : DecorativeTypeXMinus
    {
        public clayblockmagentaupsidedowncurveXMinus() : base("clayblockmagenta", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex-");
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedowncurveXPlus : DecorativeTypeXPlus
    {
        public clayblockmagentaupsidedowncurveXPlus() : base("clayblockmagenta", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex+");
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedowncurveZMinus : DecorativeTypeZMinus
    {
        public clayblockmagentaupsidedowncurveZMinus() : base("clayblockmagenta", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez-");
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedowncurveZPlus : DecorativeTypeZPlus
    {
        public clayblockmagentaupsidedowncurveZPlus() : base("clayblockmagenta", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez+");
        }
    }
}