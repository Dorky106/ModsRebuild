using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockredcurverotatedRecipe : BaseRecipe
    {
        public clayblockredcurverotatedRecipe() : base("clayblockredcurverotatedrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockredcurverotated", 1));
        }
    }

    [NCAPIType]
    public class clayblockredcurverotated : DecorativeType
    {
        public clayblockredcurverotated() : base("clayblockred", "curverotated",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockredcurverotated.png"))
        {
            this.SideAll = "clayblockred";
        }
    }

    [NCAPIType]
    public class clayblockredcurverotatedXMinus : DecorativeTypeXMinus
    {
        public clayblockredcurverotatedXMinus() : base("clayblockred", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx-");
        }
    }

    [NCAPIType]
    public class clayblockredcurverotatedXPlus : DecorativeTypeXPlus
    {
        public clayblockredcurverotatedXPlus() : base("clayblockred", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx+");
        }
    }

    [NCAPIType]
    public class clayblockredcurverotatedZMinus : DecorativeTypeZMinus
    {
        public clayblockredcurverotatedZMinus() : base("clayblockred", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz-");
        }
    }

    [NCAPIType]
    public class clayblockredcurverotatedZPlus : DecorativeTypeZPlus
    {
        public clayblockredcurverotatedZPlus() : base("clayblockred", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz+");
        }
    }
}