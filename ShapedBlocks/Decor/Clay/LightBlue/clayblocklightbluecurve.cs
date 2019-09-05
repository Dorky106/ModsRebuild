using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklightbluecurveRecipe : BaseRecipe
    {
        public clayblocklightbluecurveRecipe() : base("clayblocklightbluecurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklightbluecurve", 1));
        }
    }

    [NCAPIType]
    public class clayblocklightbluecurve : DecorativeType
    {
        public clayblocklightbluecurve() : base("clayblocklightblue", "curve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklightbluecurve.png"))
        {
            this.SideAll = "clayblocklightblue";
        }
    }

    [NCAPIType]
    public class clayblocklightbluecurveXMinus : DecorativeTypeXMinus
    {
        public clayblocklightbluecurveXMinus() : base("clayblocklightblue", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex-");
        }
    }

    [NCAPIType]
    public class clayblocklightbluecurveXPlus : DecorativeTypeXPlus
    {
        public clayblocklightbluecurveXPlus() : base("clayblocklightblue", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex+");
        }
    }

    [NCAPIType]
    public class clayblocklightbluecurveZMinus : DecorativeTypeZMinus
    {
        public clayblocklightbluecurveZMinus() : base("clayblocklightblue", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez-");
        }
    }

    [NCAPIType]
    public class clayblocklightbluecurveZPlus : DecorativeTypeZPlus
    {
        public clayblocklightbluecurveZPlus() : base("clayblocklightblue", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez+");
        }
    }
}