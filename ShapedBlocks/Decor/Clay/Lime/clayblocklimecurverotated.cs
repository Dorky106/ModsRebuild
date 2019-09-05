using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklimecurverotatedRecipe : BaseRecipe
    {
        public clayblocklimecurverotatedRecipe() : base("clayblocklimecurverotatedrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklimecurverotated", 1));
        }
    }

    [NCAPIType]
    public class clayblocklimecurverotated : DecorativeType
    {
        public clayblocklimecurverotated() : base("clayblocklime", "curverotated",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklimecurverotated.png"))
        {
            this.SideAll = "clayblocklime";
        }
    }

    [NCAPIType]
    public class clayblocklimecurverotatedXMinus : DecorativeTypeXMinus
    {
        public clayblocklimecurverotatedXMinus() : base("clayblocklime", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx-");
        }
    }

    [NCAPIType]
    public class clayblocklimecurverotatedXPlus : DecorativeTypeXPlus
    {
        public clayblocklimecurverotatedXPlus() : base("clayblocklime", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx+");
        }
    }

    [NCAPIType]
    public class clayblocklimecurverotatedZMinus : DecorativeTypeZMinus
    {
        public clayblocklimecurverotatedZMinus() : base("clayblocklime", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz-");
        }
    }

    [NCAPIType]
    public class clayblocklimecurverotatedZPlus : DecorativeTypeZPlus
    {
        public clayblocklimecurverotatedZPlus() : base("clayblocklime", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz+");
        }
    }
}