using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockorangecurverotatedRecipe : BaseRecipe
    {
        public clayblockorangecurverotatedRecipe() : base("clayblockorangecurverotatedrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockorangecurverotated", 1));
        }
    }

    [NCAPIType]
    public class clayblockorangecurverotated : DecorativeType
    {
        public clayblockorangecurverotated() : base("clayblockorange", "curverotated",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockorangecurverotated.png"))
        {
            this.SideAll = "clayblockorange";
        }
    }

    [NCAPIType]
    public class clayblockorangecurverotatedXMinus : DecorativeTypeXMinus
    {
        public clayblockorangecurverotatedXMinus() : base("clayblockorange", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx-");
        }
    }

    [NCAPIType]
    public class clayblockorangecurverotatedXPlus : DecorativeTypeXPlus
    {
        public clayblockorangecurverotatedXPlus() : base("clayblockorange", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx+");
        }
    }

    [NCAPIType]
    public class clayblockorangecurverotatedZMinus : DecorativeTypeZMinus
    {
        public clayblockorangecurverotatedZMinus() : base("clayblockorange", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz-");
        }
    }

    [NCAPIType]
    public class clayblockorangecurverotatedZPlus : DecorativeTypeZPlus
    {
        public clayblockorangecurverotatedZPlus() : base("clayblockorange", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz+");
        }
    }
}