using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpurpleslopeRecipe : BaseRecipe
    {
        public clayblockpurpleslopeRecipe() : base("clayblockpurplesloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpurpleslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockpurpleslope : DecorativeType
    {
        public clayblockpurpleslope() : base("clayblockpurple", "slope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpurpleslope.png"))
        {
            this.SideAll = "clayblockpurple";
        }
    }

    [NCAPIType]
    public class clayblockpurpleslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockpurpleslopeXMinus() : base("clayblockpurple", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex-");
        }
    }

    [NCAPIType]
    public class clayblockpurpleslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockpurpleslopeXPlus() : base("clayblockpurple", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex+");
        }
    }

    [NCAPIType]
    public class clayblockpurpleslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockpurpleslopeZMinus() : base("clayblockpurple", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez-");
        }
    }

    [NCAPIType]
    public class clayblockpurpleslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockpurpleslopeZPlus() : base("clayblockpurple", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez+");
        }
    }
}