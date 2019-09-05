using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocksilvercurverotatedRecipe : BaseRecipe
    {
        public clayblocksilvercurverotatedRecipe() : base("clayblocksilvercurverotatedrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocksilvercurverotated", 1));
        }
    }

    [NCAPIType]
    public class clayblocksilvercurverotated : DecorativeType
    {
        public clayblocksilvercurverotated() : base("clayblocksilver", "curverotated",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocksilvercurverotated.png"))
        {
            this.SideAll = "clayblocksilver";
        }
    }

    [NCAPIType]
    public class clayblocksilvercurverotatedXMinus : DecorativeTypeXMinus
    {
        public clayblocksilvercurverotatedXMinus() : base("clayblocksilver", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx-");
        }
    }

    [NCAPIType]
    public class clayblocksilvercurverotatedXPlus : DecorativeTypeXPlus
    {
        public clayblocksilvercurverotatedXPlus() : base("clayblocksilver", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx+");
        }
    }

    [NCAPIType]
    public class clayblocksilvercurverotatedZMinus : DecorativeTypeZMinus
    {
        public clayblocksilvercurverotatedZMinus() : base("clayblocksilver", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz-");
        }
    }

    [NCAPIType]
    public class clayblocksilvercurverotatedZPlus : DecorativeTypeZPlus
    {
        public clayblocksilvercurverotatedZPlus() : base("clayblocksilver", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz+");
        }
    }
}