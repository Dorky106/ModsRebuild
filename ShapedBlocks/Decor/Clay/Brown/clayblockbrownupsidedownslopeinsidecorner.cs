using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbrownupsidedownslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockbrownupsidedownslopeinsidecornerRecipe() : base("clayblockbrownupsidedownslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbrownupsidedownslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedownslopeinsidecorner : DecorativeType
    {
        public clayblockbrownupsidedownslopeinsidecorner() : base("clayblockbrown", "upsidedownslopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbrownupsidedownslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockbrown";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockbrownupsidedownslopeinsidecornerXMinus() : base("clayblockbrown", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockbrownupsidedownslopeinsidecornerXPlus() : base("clayblockbrown", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockbrownupsidedownslopeinsidecornerZMinus() : base("clayblockbrown", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockbrownupsidedownslopeinsidecornerZPlus() : base("clayblockbrown", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz+");
        }
    }
}