using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockredupsidedowncurveRecipe : BaseRecipe
    {
        public clayblockredupsidedowncurveRecipe() : base("clayblockredupsidedowncurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockredupsidedowncurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockredupsidedowncurve : DecorativeType
    {
        public clayblockredupsidedowncurve() : base("clayblockred", "upsidedowncurve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockredupsidedowncurve.png"))
        {
            this.SideAll = "clayblockred";
        }
    }

    [NCAPIType]
    public class clayblockredupsidedowncurveXMinus : DecorativeTypeXMinus
    {
        public clayblockredupsidedowncurveXMinus() : base("clayblockred", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex-");
        }
    }

    [NCAPIType]
    public class clayblockredupsidedowncurveXPlus : DecorativeTypeXPlus
    {
        public clayblockredupsidedowncurveXPlus() : base("clayblockred", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex+");
        }
    }

    [NCAPIType]
    public class clayblockredupsidedowncurveZMinus : DecorativeTypeZMinus
    {
        public clayblockredupsidedowncurveZMinus() : base("clayblockred", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez-");
        }
    }

    [NCAPIType]
    public class clayblockredupsidedowncurveZPlus : DecorativeTypeZPlus
    {
        public clayblockredupsidedowncurveZPlus() : base("clayblockred", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez+");
        }
    }
}