using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockorangecurveRecipe : BaseRecipe
    {
        public clayblockorangecurveRecipe() : base("clayblockorangecurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockorangecurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockorangecurve : DecorativeType
    {
        public clayblockorangecurve() : base("clayblockorange", "curve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockorangecurve.png"))
        {
            this.SideAll = "clayblockorange";
        }
    }

    [NCAPIType]
    public class clayblockorangecurveXMinus : DecorativeTypeXMinus
    {
        public clayblockorangecurveXMinus() : base("clayblockorange", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex-");
        }
    }

    [NCAPIType]
    public class clayblockorangecurveXPlus : DecorativeTypeXPlus
    {
        public clayblockorangecurveXPlus() : base("clayblockorange", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex+");
        }
    }

    [NCAPIType]
    public class clayblockorangecurveZMinus : DecorativeTypeZMinus
    {
        public clayblockorangecurveZMinus() : base("clayblockorange", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez-");
        }
    }

    [NCAPIType]
    public class clayblockorangecurveZPlus : DecorativeTypeZPlus
    {
        public clayblockorangecurveZPlus() : base("clayblockorange", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez+");
        }
    }
}