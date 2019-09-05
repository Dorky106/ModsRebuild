using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblackupsidedownslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockblackupsidedownslopecorneredgeRecipe() : base("clayblockblackupsidedownslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblackupsidedownslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedownslopecorneredge : DecorativeType
    {
        public clayblockblackupsidedownslopecorneredge() : base("clayblockblack", "upsidedownslopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblackupsidedownslopecorneredge.png"))
        {
            this.SideAll = "clayblockblack";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockblackupsidedownslopecorneredgeXMinus() : base("clayblockblack", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockblackupsidedownslopecorneredgeXPlus() : base("clayblockblack", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockblackupsidedownslopecorneredgeZMinus() : base("clayblockblack", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockblackupsidedownslopecorneredgeZPlus() : base("clayblockblack", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez+");
        }
    }
}