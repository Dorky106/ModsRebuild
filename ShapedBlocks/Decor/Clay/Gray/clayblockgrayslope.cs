using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgrayslopeRecipe : BaseRecipe
    {
        public clayblockgrayslopeRecipe() : base("clayblockgraysloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgrayslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockgrayslope : DecorativeType
    {
        public clayblockgrayslope() : base("clayblockgray", "slope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgrayslope.png"))
        {
            this.SideAll = "clayblockgray";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgrayslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockgrayslopeXMinus() : base("clayblockgray", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex-");
        }
    }

    [NCAPIType]
    public class clayblockgrayslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockgrayslopeXPlus() : base("clayblockgray", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex+");
        }
    }

    [NCAPIType]
    public class clayblockgrayslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockgrayslopeZMinus() : base("clayblockgray", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez-");
        }
    }

    [NCAPIType]
    public class clayblockgrayslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockgrayslopeZPlus() : base("clayblockgray", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez+");
        }
    }
}