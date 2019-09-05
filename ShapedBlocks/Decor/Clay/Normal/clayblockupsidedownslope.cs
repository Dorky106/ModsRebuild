using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockupsidedownslopeRecipe : BaseRecipe
    {
        public clayblockupsidedownslopeRecipe() : base("clayblockupsidedownsloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockupsidedownslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockupsidedownslope : DecorativeType
    {
        public clayblockupsidedownslope() : base("clayblock", "upsidedownslope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockupsidedownslope.png"))
        {
            this.SideAll = "clayblock";
        }
    }

    [NCAPIType]
    public class clayblockupsidedownslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockupsidedownslopeXMinus() : base("clayblock", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex-");
        }
    }

    [NCAPIType]
    public class clayblockupsidedownslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockupsidedownslopeXPlus() : base("clayblock", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex+");
        }
    }

    [NCAPIType]
    public class clayblockupsidedownslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockupsidedownslopeZMinus() : base("clayblock", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez-");
        }
    }

    [NCAPIType]
    public class clayblockupsidedownslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockupsidedownslopeZPlus() : base("clayblock", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez+");
        }
    }
}