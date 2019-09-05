using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblueupsidedownslopeRecipe : BaseRecipe
    {
        public clayblockblueupsidedownslopeRecipe() : base("clayblockblueupsidedownsloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblueupsidedownslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedownslope : DecorativeType
    {
        public clayblockblueupsidedownslope() : base("clayblockblue", "upsidedownslope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblueupsidedownslope.png"))
        {
            this.SideAll = "clayblockblue";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedownslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockblueupsidedownslopeXMinus() : base("clayblockblue", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex-");
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedownslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockblueupsidedownslopeXPlus() : base("clayblockblue", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex+");
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedownslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockblueupsidedownslopeZMinus() : base("clayblockblue", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez-");
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedownslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockblueupsidedownslopeZPlus() : base("clayblockblue", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez+");
        }
    }
}