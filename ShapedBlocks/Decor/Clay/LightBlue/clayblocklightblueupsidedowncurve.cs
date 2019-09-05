using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklightblueupsidedowncurveRecipe : BaseRecipe
    {
        public clayblocklightblueupsidedowncurveRecipe() : base("clayblocklightblueupsidedowncurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklightblueupsidedowncurve", 1));
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedowncurve : DecorativeType
    {
        public clayblocklightblueupsidedowncurve() : base("clayblocklightblue", "upsidedowncurve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklightblueupsidedowncurve.png"))
        {
            this.SideAll = "clayblocklightblue";
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedowncurveXMinus : DecorativeTypeXMinus
    {
        public clayblocklightblueupsidedowncurveXMinus() : base("clayblocklightblue", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex-");
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedowncurveXPlus : DecorativeTypeXPlus
    {
        public clayblocklightblueupsidedowncurveXPlus() : base("clayblocklightblue", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex+");
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedowncurveZMinus : DecorativeTypeZMinus
    {
        public clayblocklightblueupsidedowncurveZMinus() : base("clayblocklightblue", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez-");
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedowncurveZPlus : DecorativeTypeZPlus
    {
        public clayblocklightblueupsidedowncurveZPlus() : base("clayblocklightblue", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez+");
        }
    }
}