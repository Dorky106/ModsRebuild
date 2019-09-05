using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblackupsidedownslopeRecipe : BaseRecipe
    {
        public clayblockblackupsidedownslopeRecipe() : base("clayblockblackupsidedownsloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblackupsidedownslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedownslope : DecorativeType
    {
        public clayblockblackupsidedownslope() : base("clayblockblack", "upsidedownslope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblackupsidedownslope.png"))
        {
            this.SideAll = "clayblockblack";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedownslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockblackupsidedownslopeXMinus() : base("clayblockblack", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex-");
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedownslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockblackupsidedownslopeXPlus() : base("clayblockblack", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex+");
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedownslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockblackupsidedownslopeZMinus() : base("clayblockblack", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez-");
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedownslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockblackupsidedownslopeZPlus() : base("clayblockblack", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez+");
        }
    }
}