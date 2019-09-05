using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockwhiteslopeRecipe : BaseRecipe
    {
        public clayblockwhiteslopeRecipe() : base("clayblockwhitesloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockwhiteslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockwhiteslope : DecorativeType
    {
        public clayblockwhiteslope() : base("clayblockwhite", "slope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockwhiteslope.png"))
        {
            this.SideAll = "clayblockwhite";
        }
    }

    [NCAPIType]
    public class clayblockwhiteslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockwhiteslopeXMinus() : base("clayblockwhite", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex-");
        }
    }

    [NCAPIType]
    public class clayblockwhiteslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockwhiteslopeXPlus() : base("clayblockwhite", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex+");
        }
    }

    [NCAPIType]
    public class clayblockwhiteslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockwhiteslopeZMinus() : base("clayblockwhite", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez-");
        }
    }

    [NCAPIType]
    public class clayblockwhiteslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockwhiteslopeZPlus() : base("clayblockwhite", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez+");
        }
    }
}