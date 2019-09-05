using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class ClayblockyellowupsidedowncurveRecipe : BaseRecipe
    {
        public ClayblockyellowupsidedowncurveRecipe() : base("clayblockyellowupsidedowncurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockyellowupsidedowncurve", 1));
        }
    }

    [NCAPIType]
    public class Clayblockyellowupsidedowncurve : DecorativeType
    {
        public Clayblockyellowupsidedowncurve() : base("clayblockyellow", "upsidedowncurve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockyellowupsidedowncurve.png"))
        {
            this.SideAll = "clayblockyellow";
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedowncurveXMinus : DecorativeTypeXMinus
    {
        public clayblockyellowupsidedowncurveXMinus() : base("clayblockyellow", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex-");
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedowncurveXPlus : DecorativeTypeXPlus
    {
        public clayblockyellowupsidedowncurveXPlus() : base("clayblockyellow", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex+");
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedowncurveZMinus : DecorativeTypeZMinus
    {
        public clayblockyellowupsidedowncurveZMinus() : base("clayblockyellow", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez-");
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedowncurveZPlus : DecorativeTypeZPlus
    {
        public clayblockyellowupsidedowncurveZPlus() : base("clayblockyellow", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez+");
        }
    }
}