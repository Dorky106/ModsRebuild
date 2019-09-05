using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpurpleupsidedownslopeRecipe : BaseRecipe
    {
        public clayblockpurpleupsidedownslopeRecipe() : base("clayblockpurpleupsidedownsloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpurpleupsidedownslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedownslope : DecorativeType
    {
        public clayblockpurpleupsidedownslope() : base("clayblockpurple", "upsidedownslope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpurpleupsidedownslope.png"))
        {
            this.SideAll = "clayblockpurple";
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedownslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockpurpleupsidedownslopeXMinus() : base("clayblockpurple", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex-");
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedownslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockpurpleupsidedownslopeXPlus() : base("clayblockpurple", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex+");
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedownslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockpurpleupsidedownslopeZMinus() : base("clayblockpurple", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez-");
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedownslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockpurpleupsidedownslopeZPlus() : base("clayblockpurple", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez+");
        }
    }
}