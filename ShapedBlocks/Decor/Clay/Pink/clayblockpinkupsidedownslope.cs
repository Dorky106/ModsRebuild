using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpinkupsidedownslopeRecipe : BaseRecipe
    {
        public clayblockpinkupsidedownslopeRecipe() : base("clayblockpinkupsidedownsloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpinkupsidedownslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedownslope : DecorativeType
    {
        public clayblockpinkupsidedownslope() : base("clayblockpink", "upsidedownslope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpinkupsidedownslope.png"))
        {
            this.SideAll = "clayblockpink";
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedownslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockpinkupsidedownslopeXMinus() : base("clayblockpink", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex-");
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedownslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockpinkupsidedownslopeXPlus() : base("clayblockpink", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex+");
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedownslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockpinkupsidedownslopeZMinus() : base("clayblockpink", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez-");
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedownslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockpinkupsidedownslopeZPlus() : base("clayblockpink", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez+");
        }
    }
}