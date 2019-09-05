using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbrownupsidedownslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockbrownupsidedownslopecorneredgeRecipe() : base("clayblockbrownupsidedownslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbrownupsidedownslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedownslopecorneredge : DecorativeType
    {
        public clayblockbrownupsidedownslopecorneredge() : base("clayblockbrown", "upsidedownslopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbrownupsidedownslopecorneredge.png"))
        {
            this.SideAll = "clayblockbrown";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockbrownupsidedownslopecorneredgeXMinus() : base("clayblockbrown", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockbrownupsidedownslopecorneredgeXPlus() : base("clayblockbrown", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockbrownupsidedownslopecorneredgeZMinus() : base("clayblockbrown", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockbrownupsidedownslopecorneredgeZPlus() : base("clayblockbrown", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez+");
        }
    }
}