using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockcyancurverotatedRecipe : BaseRecipe
    {
        public clayblockcyancurverotatedRecipe() : base("clayblockcyancurverotatedrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockcyancurverotated", 1));
        }
    }

    [NCAPIType]
    public class clayblockcyancurverotated : DecorativeType
    {
        public clayblockcyancurverotated() : base("clayblockcyan", "curverotated",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockcyancurverotated.png"))
        {
            this.SideAll = "clayblockcyan";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockcyancurverotatedXMinus : DecorativeTypeXMinus
    {
        public clayblockcyancurverotatedXMinus() : base("clayblockcyan", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx-");
        }
    }

    [NCAPIType]
    public class clayblockcyancurverotatedXPlus : DecorativeTypeXPlus
    {
        public clayblockcyancurverotatedXPlus() : base("clayblockcyan", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx+");
        }
    }

    [NCAPIType]
    public class clayblockcyancurverotatedZMinus : DecorativeTypeZMinus
    {
        public clayblockcyancurverotatedZMinus() : base("clayblockcyan", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz-");
        }
    }

    [NCAPIType]
    public class clayblockcyancurverotatedZPlus : DecorativeTypeZPlus
    {
        public clayblockcyancurverotatedZPlus() : base("clayblockcyan", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz+");
        }
    }
}