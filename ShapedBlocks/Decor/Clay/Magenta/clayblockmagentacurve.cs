using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockmagentacurveRecipe : BaseRecipe
    {
        public clayblockmagentacurveRecipe() : base("clayblockmagentacurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockmagentacurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockmagentacurve : DecorativeType
    {
        public clayblockmagentacurve() : base("clayblockmagenta", "curve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockmagentacurve.png"))
        {
            this.SideAll = "clayblockmagenta";
        }
    }

    [NCAPIType]
    public class clayblockmagentacurveXMinus : DecorativeTypeXMinus
    {
        public clayblockmagentacurveXMinus() : base("clayblockmagenta", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex-");
        }
    }

    [NCAPIType]
    public class clayblockmagentacurveXPlus : DecorativeTypeXPlus
    {
        public clayblockmagentacurveXPlus() : base("clayblockmagenta", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex+");
        }
    }

    [NCAPIType]
    public class clayblockmagentacurveZMinus : DecorativeTypeZMinus
    {
        public clayblockmagentacurveZMinus() : base("clayblockmagenta", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez-");
        }
    }

    [NCAPIType]
    public class clayblockmagentacurveZPlus : DecorativeTypeZPlus
    {
        public clayblockmagentacurveZPlus() : base("clayblockmagenta", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez+");
        }
    }
}