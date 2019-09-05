using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockwhitecurverotatedRecipe : BaseRecipe
    {
        public clayblockwhitecurverotatedRecipe() : base("clayblockwhitecurverotatedrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockwhitecurverotated", 1));
        }
    }

    [NCAPIType]
    public class clayblockwhitecurverotated : DecorativeType
    {
        public clayblockwhitecurverotated() : base("clayblockwhite", "curverotated",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockwhitecurverotated.png"))
        {
            this.SideAll = "clayblockwhite";
        }
    }

    [NCAPIType]
    public class clayblockwhitecurverotatedXMinus : DecorativeTypeXMinus
    {
        public clayblockwhitecurverotatedXMinus() : base("clayblockwhite", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx-");
        }
    }

    [NCAPIType]
    public class clayblockwhitecurverotatedXPlus : DecorativeTypeXPlus
    {
        public clayblockwhitecurverotatedXPlus() : base("clayblockwhite", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx+");
        }
    }

    [NCAPIType]
    public class clayblockwhitecurverotatedZMinus : DecorativeTypeZMinus
    {
        public clayblockwhitecurverotatedZMinus() : base("clayblockwhite", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz-");
        }
    }

    [NCAPIType]
    public class clayblockwhitecurverotatedZPlus : DecorativeTypeZPlus
    {
        public clayblockwhitecurverotatedZPlus() : base("clayblockwhite", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz+");
        }
    }
}