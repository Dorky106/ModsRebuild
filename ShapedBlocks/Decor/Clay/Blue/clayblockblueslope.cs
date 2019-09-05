using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblueslopeRecipe : BaseRecipe
    {
        public clayblockblueslopeRecipe() : base("clayblockbluesloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblueslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockblueslope : DecorativeType
    {
        public clayblockblueslope() : base("clayblockblue", "slope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblueslope.png"))
        {
            this.SideAll = "clayblockblue";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblueslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockblueslopeXMinus() : base("clayblockblue", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex-");
        }
    }

    [NCAPIType]
    public class clayblockblueslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockblueslopeXPlus() : base("clayblockblue", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex+");
        }
    }

    [NCAPIType]
    public class clayblockblueslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockblueslopeZMinus() : base("clayblockblue", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez-");
        }
    }

    [NCAPIType]
    public class clayblockblueslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockblueslopeZPlus() : base("clayblockblue", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez+");
        }
    }
}