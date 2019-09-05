using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbluecurverotatedRecipe : BaseRecipe
    {
        public clayblockbluecurverotatedRecipe() : base("clayblockbluecurverotatedrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbluecurverotated", 1));
        }
    }

    [NCAPIType]
    public class clayblockbluecurverotated : DecorativeType
    {
        public clayblockbluecurverotated() : base("clayblockblue", "curverotated",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbluecurverotated.png"))
        {
            this.SideAll = "clayblockblue";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbluecurverotatedXMinus : DecorativeTypeXMinus
    {
        public clayblockbluecurverotatedXMinus() : base("clayblockblue", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx-");
        }
    }

    [NCAPIType]
    public class clayblockbluecurverotatedXPlus : DecorativeTypeXPlus
    {
        public clayblockbluecurverotatedXPlus() : base("clayblockblue", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx+");
        }
    }

    [NCAPIType]
    public class clayblockbluecurverotatedZMinus : DecorativeTypeZMinus
    {
        public clayblockbluecurverotatedZMinus() : base("clayblockblue", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz-");
        }
    }

    [NCAPIType]
    public class clayblockbluecurverotatedZPlus : DecorativeTypeZPlus
    {
        public clayblockbluecurverotatedZPlus() : base("clayblockblue", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz+");
        }
    }
}