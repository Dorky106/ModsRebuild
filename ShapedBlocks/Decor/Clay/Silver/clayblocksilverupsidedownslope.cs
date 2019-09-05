using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocksilverupsidedownslopeRecipe : BaseRecipe
    {
        public clayblocksilverupsidedownslopeRecipe() : base("clayblocksilverupsidedownsloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocksilverupsidedownslope", 1));
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedownslope : DecorativeType
    {
        public clayblocksilverupsidedownslope() : base("clayblocksilver", "upsidedownslope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocksilverupsidedownslope.png"))
        {
            this.SideAll = "clayblocksilver";
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedownslopeXMinus : DecorativeTypeXMinus
    {
        public clayblocksilverupsidedownslopeXMinus() : base("clayblocksilver", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex-");
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedownslopeXPlus : DecorativeTypeXPlus
    {
        public clayblocksilverupsidedownslopeXPlus() : base("clayblocksilver", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex+");
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedownslopeZMinus : DecorativeTypeZMinus
    {
        public clayblocksilverupsidedownslopeZMinus() : base("clayblocksilver", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez-");
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedownslopeZPlus : DecorativeTypeZPlus
    {
        public clayblocksilverupsidedownslopeZPlus() : base("clayblocksilver", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez+");
        }
    }
}