using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockwhiteupsidedownslopeRecipe : BaseRecipe
    {
        public clayblockwhiteupsidedownslopeRecipe() : base("clayblockwhiteupsidedownsloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockwhiteupsidedownslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedownslope : DecorativeType
    {
        public clayblockwhiteupsidedownslope() : base("clayblockwhite", "upsidedownslope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockwhiteupsidedownslope.png"))
        {
            this.SideAll = "clayblockwhite";
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedownslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockwhiteupsidedownslopeXMinus() : base("clayblockwhite", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex-");
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedownslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockwhiteupsidedownslopeXPlus() : base("clayblockwhite", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex+");
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedownslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockwhiteupsidedownslopeZMinus() : base("clayblockwhite", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez-");
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedownslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockwhiteupsidedownslopeZPlus() : base("clayblockwhite", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez+");
        }
    }
}