using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklimeupsidedowncurveRecipe : BaseRecipe
    {
        public clayblocklimeupsidedowncurveRecipe() : base("clayblocklimeupsidedowncurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklimeupsidedowncurve", 1));
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedowncurve : DecorativeType
    {
        public clayblocklimeupsidedowncurve() : base("clayblocklime", "upsidedowncurve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklimeupsidedowncurve.png"))
        {
            this.SideAll = "clayblocklime";
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedowncurveXMinus : DecorativeTypeXMinus
    {
        public clayblocklimeupsidedowncurveXMinus() : base("clayblocklime", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex-");
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedowncurveXPlus : DecorativeTypeXPlus
    {
        public clayblocklimeupsidedowncurveXPlus() : base("clayblocklime", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex+");
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedowncurveZMinus : DecorativeTypeZMinus
    {
        public clayblocklimeupsidedowncurveZMinus() : base("clayblocklime", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez-");
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedowncurveZPlus : DecorativeTypeZPlus
    {
        public clayblocklimeupsidedowncurveZPlus() : base("clayblocklime", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez+");
        }
    }
}