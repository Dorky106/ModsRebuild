using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgrayupsidedownslopeRecipe : BaseRecipe
    {
        public clayblockgrayupsidedownslopeRecipe() : base("clayblockgrayupsidedownsloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgrayupsidedownslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedownslope : DecorativeType
    {
        public clayblockgrayupsidedownslope() : base("clayblockgray", "upsidedownslope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgrayupsidedownslope.png"))
        {
            this.SideAll = "clayblockgray";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedownslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockgrayupsidedownslopeXMinus() : base("clayblockgray", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex-");
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedownslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockgrayupsidedownslopeXPlus() : base("clayblockgray", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex+");
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedownslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockgrayupsidedownslopeZMinus() : base("clayblockgray", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez-");
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedownslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockgrayupsidedownslopeZPlus() : base("clayblockgray", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez+");
        }
    }
}