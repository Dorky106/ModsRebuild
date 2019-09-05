using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockcyancurveRecipe : BaseRecipe
    {
        public clayblockcyancurveRecipe() : base("clayblockcyancurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockcyancurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockcyancurve : DecorativeType
    {
        public clayblockcyancurve() : base("clayblockcyan", "curve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockcyancurve.png"))
        {
            this.SideAll = "clayblockcyan";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockcyancurveXMinus : DecorativeTypeXMinus
    {
        public clayblockcyancurveXMinus() : base("clayblockcyan", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex-");
        }
    }

    [NCAPIType]
    public class clayblockcyancurveXPlus : DecorativeTypeXPlus
    {
        public clayblockcyancurveXPlus() : base("clayblockcyan", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex+");
        }
    }

    [NCAPIType]
    public class clayblockcyancurveZMinus : DecorativeTypeZMinus
    {
        public clayblockcyancurveZMinus() : base("clayblockcyan", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez-");
        }
    }

    [NCAPIType]
    public class clayblockcyancurveZPlus : DecorativeTypeZPlus
    {
        public clayblockcyancurveZPlus() : base("clayblockcyan", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez+");
        }
    }
}