using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbrowncurverotatedRecipe : BaseRecipe
    {
        public clayblockbrowncurverotatedRecipe() : base("clayblockbrowncurverotatedrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbrowncurverotated", 1));
        }
    }

    [NCAPIType]
    public class clayblockbrowncurverotated : DecorativeType
    {
        public clayblockbrowncurverotated() : base("clayblockbrown", "curverotated",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbrowncurverotated.png"))
        {
            this.SideAll = "clayblockbrown";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbrowncurverotatedXMinus : DecorativeTypeXMinus
    {
        public clayblockbrowncurverotatedXMinus() : base("clayblockbrown", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx-");
        }
    }

    [NCAPIType]
    public class clayblockbrowncurverotatedXPlus : DecorativeTypeXPlus
    {
        public clayblockbrowncurverotatedXPlus() : base("clayblockbrown", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx+");
        }
    }

    [NCAPIType]
    public class clayblockbrowncurverotatedZMinus : DecorativeTypeZMinus
    {
        public clayblockbrowncurverotatedZMinus() : base("clayblockbrown", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz-");
        }
    }

    [NCAPIType]
    public class clayblockbrowncurverotatedZPlus : DecorativeTypeZPlus
    {
        public clayblockbrowncurverotatedZPlus() : base("clayblockbrown", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz+");
        }
    }
}