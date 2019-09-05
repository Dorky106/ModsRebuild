using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbrownupsidedownslopecornerRecipe : BaseRecipe
    {
        public clayblockbrownupsidedownslopecornerRecipe() : base("clayblockbrownupsidedownslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbrownupsidedownslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedownslopecorner : DecorativeType
    {
        public clayblockbrownupsidedownslopecorner() : base("clayblockbrown", "upsidedownslopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbrownupsidedownslopecorner.png"))
        {
            this.SideAll = "clayblockbrown";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedownslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockbrownupsidedownslopecornerXMinus() : base("clayblockbrown", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedownslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockbrownupsidedownslopecornerXPlus() : base("clayblockbrown", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedownslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockbrownupsidedownslopecornerZMinus() : base("clayblockbrown", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedownslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockbrownupsidedownslopecornerZPlus() : base("clayblockbrown", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz+");
        }
    }
}