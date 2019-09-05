using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockmagentacurverotatedRecipe : BaseRecipe
    {
        public clayblockmagentacurverotatedRecipe() : base("clayblockmagentacurverotatedrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockmagentacurverotated", 1));
        }
    }

    [NCAPIType]
    public class clayblockmagentacurverotated : DecorativeType
    {
        public clayblockmagentacurverotated() : base("clayblockmagenta", "curverotated",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockmagentacurverotated.png"))
        {
            this.SideAll = "clayblockmagenta";
        }
    }

    [NCAPIType]
    public class clayblockmagentacurverotatedXMinus : DecorativeTypeXMinus
    {
        public clayblockmagentacurverotatedXMinus() : base("clayblockmagenta", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx-");
        }
    }

    [NCAPIType]
    public class clayblockmagentacurverotatedXPlus : DecorativeTypeXPlus
    {
        public clayblockmagentacurverotatedXPlus() : base("clayblockmagenta", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx+");
        }
    }

    [NCAPIType]
    public class clayblockmagentacurverotatedZMinus : DecorativeTypeZMinus
    {
        public clayblockmagentacurverotatedZMinus() : base("clayblockmagenta", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz-");
        }
    }

    [NCAPIType]
    public class clayblockmagentacurverotatedZPlus : DecorativeTypeZPlus
    {
        public clayblockmagentacurverotatedZPlus() : base("clayblockmagenta", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz+");
        }
    }
}