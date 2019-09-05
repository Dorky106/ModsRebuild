using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockmagentaupsidedownslopeRecipe : BaseRecipe
    {
        public clayblockmagentaupsidedownslopeRecipe() : base("clayblockmagentaupsidedownsloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockmagentaupsidedownslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedownslope : DecorativeType
    {
        public clayblockmagentaupsidedownslope() : base("clayblockmagenta", "upsidedownslope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockmagentaupsidedownslope.png"))
        {
            this.SideAll = "clayblockmagenta";
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedownslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockmagentaupsidedownslopeXMinus() : base("clayblockmagenta", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex-");
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedownslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockmagentaupsidedownslopeXPlus() : base("clayblockmagenta", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex+");
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedownslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockmagentaupsidedownslopeZMinus() : base("clayblockmagenta", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez-");
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedownslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockmagentaupsidedownslopeZPlus() : base("clayblockmagenta", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez+");
        }
    }
}