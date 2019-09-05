using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockcyanupsidedowncurveRecipe : BaseRecipe
    {
        public clayblockcyanupsidedowncurveRecipe() : base("clayblockcyanupsidedowncurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockcyanupsidedowncurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedowncurve : DecorativeType
    {
        public clayblockcyanupsidedowncurve() : base("clayblockcyan", "upsidedowncurve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockcyanupsidedowncurve.png"))
        {
            this.SideAll = "clayblockcyan";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedowncurveXMinus : DecorativeTypeXMinus
    {
        public clayblockcyanupsidedowncurveXMinus() : base("clayblockcyan", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex-");
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedowncurveXPlus : DecorativeTypeXPlus
    {
        public clayblockcyanupsidedowncurveXPlus() : base("clayblockcyan", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex+");
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedowncurveZMinus : DecorativeTypeZMinus
    {
        public clayblockcyanupsidedowncurveZMinus() : base("clayblockcyan", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez-");
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedowncurveZPlus : DecorativeTypeZPlus
    {
        public clayblockcyanupsidedowncurveZPlus() : base("clayblockcyan", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez+");
        }
    }
}