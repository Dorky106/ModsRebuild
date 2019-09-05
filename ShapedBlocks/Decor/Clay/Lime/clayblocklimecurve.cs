using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklimecurveRecipe : BaseRecipe
    {
        public clayblocklimecurveRecipe() : base("clayblocklimecurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklimecurve", 1));
        }
    }

    [NCAPIType]
    public class clayblocklimecurve : DecorativeType
    {
        public clayblocklimecurve() : base("clayblocklime", "curve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklimecurve.png"))
        {
            this.SideAll = "clayblocklime";
        }
    }

    [NCAPIType]
    public class clayblocklimecurveXMinus : DecorativeTypeXMinus
    {
        public clayblocklimecurveXMinus() : base("clayblocklime", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex-");
        }
    }

    [NCAPIType]
    public class clayblocklimecurveXPlus : DecorativeTypeXPlus
    {
        public clayblocklimecurveXPlus() : base("clayblocklime", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex+");
        }
    }

    [NCAPIType]
    public class clayblocklimecurveZMinus : DecorativeTypeZMinus
    {
        public clayblocklimecurveZMinus() : base("clayblocklime", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez-");
        }
    }

    [NCAPIType]
    public class clayblocklimecurveZPlus : DecorativeTypeZPlus
    {
        public clayblocklimecurveZPlus() : base("clayblocklime", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez+");
        }
    }
}