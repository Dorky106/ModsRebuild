using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class ClayblockyellowcurveRecipe : BaseRecipe
    {
        public ClayblockyellowcurveRecipe() : base("clayblockyellowcurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockyellowcurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockyellowcurve : DecorativeType
    {
        public clayblockyellowcurve() : base("clayblockyellow", "curve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockyellowcurve.png"))
        {
            this.SideAll = "clayblockyellow";
        }
    }

    [NCAPIType]
    public class clayblockyellowcurveXMinus : DecorativeTypeXMinus
    {
        public clayblockyellowcurveXMinus() : base("clayblockyellow", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex-");
        }
    }

    [NCAPIType]
    public class clayblockyellowcurveXPlus : DecorativeTypeXPlus
    {
        public clayblockyellowcurveXPlus() : base("clayblockyellow", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex+");
        }
    }

    [NCAPIType]
    public class clayblockyellowcurveZMinus : DecorativeTypeZMinus
    {
        public clayblockyellowcurveZMinus() : base("clayblockyellow", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez-");
        }
    }

    [NCAPIType]
    public class clayblockyellowcurveZPlus : DecorativeTypeZPlus
    {
        public clayblockyellowcurveZPlus() : base("clayblockyellow", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez+");
        }
    }
}