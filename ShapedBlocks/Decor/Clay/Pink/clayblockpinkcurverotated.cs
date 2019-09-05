using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpinkcurverotatedRecipe : BaseRecipe
    {
        public clayblockpinkcurverotatedRecipe() : base("clayblockpinkcurverotatedrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpinkcurverotated", 1));
        }
    }

    [NCAPIType]
    public class clayblockpinkcurverotated : DecorativeType
    {
        public clayblockpinkcurverotated() : base("clayblockpink", "curverotated",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpinkcurverotated.png"))
        {
            this.SideAll = "clayblockpink";
        }
    }

    [NCAPIType]
    public class clayblockpinkcurverotatedXMinus : DecorativeTypeXMinus
    {
        public clayblockpinkcurverotatedXMinus() : base("clayblockpink", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx-");
        }
    }

    [NCAPIType]
    public class clayblockpinkcurverotatedXPlus : DecorativeTypeXPlus
    {
        public clayblockpinkcurverotatedXPlus() : base("clayblockpink", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx+");
        }
    }

    [NCAPIType]
    public class clayblockpinkcurverotatedZMinus : DecorativeTypeZMinus
    {
        public clayblockpinkcurverotatedZMinus() : base("clayblockpink", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz-");
        }
    }

    [NCAPIType]
    public class clayblockpinkcurverotatedZPlus : DecorativeTypeZPlus
    {
        public clayblockpinkcurverotatedZPlus() : base("clayblockpink", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz+");
        }
    }
}