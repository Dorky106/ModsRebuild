using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblackcurverotatedRecipe : BaseRecipe
    {
        public clayblockblackcurverotatedRecipe() : base("clayblockblackcurverotatedrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblackcurverotated", 1));
        }
    }

    [NCAPIType]
    public class clayblockblackcurverotated : DecorativeType
    {
        public clayblockblackcurverotated() : base("clayblockblack", "curverotated",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblackcurverotated.png"))
        {
            this.SideAll = "clayblockblack";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblackcurverotatedXMinus : DecorativeTypeXMinus
    {
        public clayblockblackcurverotatedXMinus() : base("clayblockblack", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx-");
        }
    }

    [NCAPIType]
    public class clayblockblackcurverotatedXPlus : DecorativeTypeXPlus
    {
        public clayblockblackcurverotatedXPlus() : base("clayblockblack", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx+");
        }
    }

    [NCAPIType]
    public class clayblockblackcurverotatedZMinus : DecorativeTypeZMinus
    {
        public clayblockblackcurverotatedZMinus() : base("clayblockblack", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz-");
        }
    }

    [NCAPIType]
    public class clayblockblackcurverotatedZPlus : DecorativeTypeZPlus
    {
        public clayblockblackcurverotatedZPlus() : base("clayblockblack", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz+");
        }
    }
}