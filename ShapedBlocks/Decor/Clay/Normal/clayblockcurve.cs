using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockcurveRecipe : BaseRecipe
    {
        public clayblockcurveRecipe() : base("clayblockcurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockcurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockcurve : DecorativeType
    {
        public clayblockcurve() : base("clayblock", "curve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockcurve.png"))
        {
            this.SideAll = "clayblock";
        }
    }

    [NCAPIType]
    public class clayblockcurveXMinus : DecorativeTypeXMinus
    {
        public clayblockcurveXMinus() : base("clayblock", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex-");
        }
    }

    [NCAPIType]
    public class clayblockcurveXPlus : DecorativeTypeXPlus
    {
        public clayblockcurveXPlus() : base("clayblock", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex+");
        }
    }

    [NCAPIType]
    public class clayblockcurveZMinus : DecorativeTypeZMinus
    {
        public clayblockcurveZMinus() : base("clayblock", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez-");
        }
    }

    [NCAPIType]
    public class clayblockcurveZPlus : DecorativeTypeZPlus
    {
        public clayblockcurveZPlus() : base("clayblock", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez+");
        }
    }
}