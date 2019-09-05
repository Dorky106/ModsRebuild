using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockwhiteupsidedownslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockwhiteupsidedownslopecorneredgeRecipe() : base("clayblockwhiteupsidedownslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockwhiteupsidedownslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedownslopecorneredge : DecorativeType
    {
        public clayblockwhiteupsidedownslopecorneredge() : base("clayblockwhite", "upsidedownslopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockwhiteupsidedownslopecorneredge.png"))
        {
            this.SideAll = "clayblockwhite";
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockwhiteupsidedownslopecorneredgeXMinus() : base("clayblockwhite", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockwhiteupsidedownslopecorneredgeXPlus() : base("clayblockwhite", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockwhiteupsidedownslopecorneredgeZMinus() : base("clayblockwhite", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockwhiteupsidedownslopecorneredgeZPlus() : base("clayblockwhite", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez+");
        }
    }
}