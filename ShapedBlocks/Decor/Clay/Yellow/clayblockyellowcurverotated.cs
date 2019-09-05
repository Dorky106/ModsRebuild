using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockyellowcurverotatedRecipe : BaseRecipe
    {
        public clayblockyellowcurverotatedRecipe() : base("clayblockyellowcurverotatedrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockyellowcurverotated", 1));
        }
    }

    [NCAPIType]
    public class clayblockyellowcurverotated : DecorativeType
    {
        public clayblockyellowcurverotated() : base("clayblockyellow", "curverotated",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockyellowcurverotated.png"))
        {
            this.SideAll = "clayblockyellow";
        }
    }

    [NCAPIType]
    public class clayblockyellowcurverotatedXMinus : DecorativeTypeXMinus
    {
        public clayblockyellowcurverotatedXMinus() : base("clayblockyellow", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx-");
        }
    }

    [NCAPIType]
    public class clayblockyellowcurverotatedXPlus : DecorativeTypeXPlus
    {
        public clayblockyellowcurverotatedXPlus() : base("clayblockyellow", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx+");
        }
    }

    [NCAPIType]
    public class clayblockyellowcurverotatedZMinus : DecorativeTypeZMinus
    {
        public clayblockyellowcurverotatedZMinus() : base("clayblockyellow", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz-");
        }
    }

    [NCAPIType]
    public class clayblockyellowcurverotatedZPlus : DecorativeTypeZPlus
    {
        public clayblockyellowcurverotatedZPlus() : base("clayblockyellow", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz+");
        }
    }
}