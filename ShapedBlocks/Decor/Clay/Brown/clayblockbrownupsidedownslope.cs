using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbrownupsidedownslopeRecipe : BaseRecipe
    {
        public clayblockbrownupsidedownslopeRecipe() : base("clayblockbrownupsidedownsloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbrownupsidedownslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedownslope : DecorativeType
    {
        public clayblockbrownupsidedownslope() : base("clayblockbrown", "upsidedownslope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbrownupsidedownslope.png"))
        {
            this.SideAll = "clayblockbrown";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedownslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockbrownupsidedownslopeXMinus() : base("clayblockbrown", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex-");
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedownslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockbrownupsidedownslopeXPlus() : base("clayblockbrown", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex+");
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedownslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockbrownupsidedownslopeZMinus() : base("clayblockbrown", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez-");
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedownslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockbrownupsidedownslopeZPlus() : base("clayblockbrown", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez+");
        }
    }
}