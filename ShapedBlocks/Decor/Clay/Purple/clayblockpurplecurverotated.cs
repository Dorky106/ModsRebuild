using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpurplecurverotatedRecipe : BaseRecipe
    {
        public clayblockpurplecurverotatedRecipe() : base("clayblockpurplecurverotatedrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpurplecurverotated", 1));
        }
    }

    [NCAPIType]
    public class clayblockpurplecurverotated : DecorativeType
    {
        public clayblockpurplecurverotated() : base("clayblockpurple", "curverotated",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpurplecurverotated.png"))
        {
            this.SideAll = "clayblockpurple";
        }
    }

    [NCAPIType]
    public class clayblockpurplecurverotatedXMinus : DecorativeTypeXMinus
    {
        public clayblockpurplecurverotatedXMinus() : base("clayblockpurple", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx-");
        }
    }

    [NCAPIType]
    public class clayblockpurplecurverotatedXPlus : DecorativeTypeXPlus
    {
        public clayblockpurplecurverotatedXPlus() : base("clayblockpurple", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx+");
        }
    }

    [NCAPIType]
    public class clayblockpurplecurverotatedZMinus : DecorativeTypeZMinus
    {
        public clayblockpurplecurverotatedZMinus() : base("clayblockpurple", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz-");
        }
    }

    [NCAPIType]
    public class clayblockpurplecurverotatedZPlus : DecorativeTypeZPlus
    {
        public clayblockpurplecurverotatedZPlus() : base("clayblockpurple", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz+");
        }
    }
}