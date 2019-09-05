using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblackslopeRecipe : BaseRecipe
    {
        public clayblockblackslopeRecipe() : base("clayblockblacksloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblackslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockblackslope : DecorativeType
    {
        public clayblockblackslope() : base("clayblockblack", "slope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblackslope.png"))
        {
            this.SideAll = "clayblockblack";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblackslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockblackslopeXMinus() : base("clayblockblack", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex-");
        }
    }

    [NCAPIType]
    public class clayblockblackslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockblackslopeXPlus() : base("clayblockblack", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex+");
        }
    }

    [NCAPIType]
    public class clayblockblackslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockblackslopeZMinus() : base("clayblockblack", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez-");
        }
    }

    [NCAPIType]
    public class clayblockblackslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockblackslopeZPlus() : base("clayblockblack", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez+");
        }
    }
}