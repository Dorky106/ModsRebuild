using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockcurverotatedRecipe : BaseRecipe
    {
        public clayblockcurverotatedRecipe() : base("clayblockcurverotatedrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockcurverotated", 1));
        }
    }

    [NCAPIType]
    public class clayblockcurverotated : DecorativeType
    {
        public clayblockcurverotated() : base("clayblock", "curverotated",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockcurverotated.png"))
        {
            this.SideAll = "clayblock";
        }
    }

    [NCAPIType]
    public class clayblockcurverotatedXMinus : DecorativeTypeXMinus
    {
        public clayblockcurverotatedXMinus() : base("clayblock", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx-");
        }
    }

    [NCAPIType]
    public class clayblockcurverotatedXPlus : DecorativeTypeXPlus
    {
        public clayblockcurverotatedXPlus() : base("clayblock", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx+");
        }
    }

    [NCAPIType]
    public class clayblockcurverotatedZMinus : DecorativeTypeZMinus
    {
        public clayblockcurverotatedZMinus() : base("clayblock", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz-");
        }
    }

    [NCAPIType]
    public class clayblockcurverotatedZPlus : DecorativeTypeZPlus
    {
        public clayblockcurverotatedZPlus() : base("clayblock", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz+");
        }
    }
}