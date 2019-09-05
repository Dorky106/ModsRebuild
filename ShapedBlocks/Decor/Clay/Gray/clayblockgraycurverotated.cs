using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgraycurverotatedRecipe : BaseRecipe
    {
        public clayblockgraycurverotatedRecipe() : base("clayblockgraycurverotatedrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgraycurverotated", 1));
        }
    }

    [NCAPIType]
    public class clayblockgraycurverotated : DecorativeType
    {
        public clayblockgraycurverotated() : base("clayblockgray", "curverotated",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgraycurverotated.png"))
        {
            this.SideAll = "clayblockgray";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgraycurverotatedXMinus : DecorativeTypeXMinus
    {
        public clayblockgraycurverotatedXMinus() : base("clayblockgray", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx-");
        }
    }

    [NCAPIType]
    public class clayblockgraycurverotatedXPlus : DecorativeTypeXPlus
    {
        public clayblockgraycurverotatedXPlus() : base("clayblockgray", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx+");
        }
    }

    [NCAPIType]
    public class clayblockgraycurverotatedZMinus : DecorativeTypeZMinus
    {
        public clayblockgraycurverotatedZMinus() : base("clayblockgray", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz-");
        }
    }

    [NCAPIType]
    public class clayblockgraycurverotatedZPlus : DecorativeTypeZPlus
    {
        public clayblockgraycurverotatedZPlus() : base("clayblockgray", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz+");
        }
    }
}