using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockorangeupsidedowncurveRecipe : BaseRecipe
    {
        public clayblockorangeupsidedowncurveRecipe() : base("clayblockorangeupsidedowncurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockorangeupsidedowncurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedowncurve : DecorativeType
    {
        public clayblockorangeupsidedowncurve() : base("clayblockorange", "upsidedowncurve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockorangeupsidedowncurve.png"))
        {
            this.SideAll = "clayblockorange";
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedowncurveXMinus : DecorativeTypeXMinus
    {
        public clayblockorangeupsidedowncurveXMinus() : base("clayblockorange", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex-");
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedowncurveXPlus : DecorativeTypeXPlus
    {
        public clayblockorangeupsidedowncurveXPlus() : base("clayblockorange", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex+");
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedowncurveZMinus : DecorativeTypeZMinus
    {
        public clayblockorangeupsidedowncurveZMinus() : base("clayblockorange", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez-");
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedowncurveZPlus : DecorativeTypeZPlus
    {
        public clayblockorangeupsidedowncurveZPlus() : base("clayblockorange", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez+");
        }
    }
}