using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpurpleupsidedownslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockpurpleupsidedownslopecorneredgeRecipe() : base("clayblockpurpleupsidedownslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpurpleupsidedownslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedownslopecorneredge : DecorativeType
    {
        public clayblockpurpleupsidedownslopecorneredge() : base("clayblockpurple", "upsidedownslopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpurpleupsidedownslopecorneredge.png"))
        {
            this.SideAll = "clayblockpurple";
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockpurpleupsidedownslopecorneredgeXMinus() : base("clayblockpurple", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockpurpleupsidedownslopecorneredgeXPlus() : base("clayblockpurple", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockpurpleupsidedownslopecorneredgeZMinus() : base("clayblockpurple", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockpurpleupsidedownslopecorneredgeZPlus() : base("clayblockpurple", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez+");
        }
    }
}