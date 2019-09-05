using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpinkupsidedownslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockpinkupsidedownslopecorneredgeRecipe() : base("clayblockpinkupsidedownslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpinkupsidedownslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedownslopecorneredge : DecorativeType
    {
        public clayblockpinkupsidedownslopecorneredge() : base("clayblockpink", "upsidedownslopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpinkupsidedownslopecorneredge.png"))
        {
            this.SideAll = "clayblockpink";
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockpinkupsidedownslopecorneredgeXMinus() : base("clayblockpink", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockpinkupsidedownslopecorneredgeXPlus() : base("clayblockpink", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockpinkupsidedownslopecorneredgeZMinus() : base("clayblockpink", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockpinkupsidedownslopecorneredgeZPlus() : base("clayblockpink", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez+");
        }
    }
}