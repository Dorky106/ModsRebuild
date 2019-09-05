using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgreenslopeRecipe : BaseRecipe
    {
        public clayblockgreenslopeRecipe() : base("clayblockgreensloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgreenslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockgreenslope : DecorativeType
    {
        public clayblockgreenslope() : base("clayblockgreen", "slope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgreenslope.png"))
        {
            this.SideAll = "clayblockgreen";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgreenslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockgreenslopeXMinus() : base("clayblockgreen", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex-");
        }
    }

    [NCAPIType]
    public class clayblockgreenslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockgreenslopeXPlus() : base("clayblockgreen", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex+");
        }
    }

    [NCAPIType]
    public class clayblockgreenslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockgreenslopeZMinus() : base("clayblockgreen", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez-");
        }
    }

    [NCAPIType]
    public class clayblockgreenslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockgreenslopeZPlus() : base("clayblockgreen", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez+");
        }
    }
}