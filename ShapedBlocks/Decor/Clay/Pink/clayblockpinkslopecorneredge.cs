using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpinkslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockpinkslopecorneredgeRecipe() : base("clayblockpinkslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpinkslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblockpinkslopecorneredge : DecorativeType
    {
        public clayblockpinkslopecorneredge() : base("clayblockpink", "slopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpinkslopecorneredge.png"))
        {
            this.SideAll = "clayblockpink";
        }
    }

    [NCAPIType]
    public class clayblockpinkslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockpinkslopecorneredgeXMinus() : base("clayblockpink", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockpinkslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockpinkslopecorneredgeXPlus() : base("clayblockpink", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockpinkslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockpinkslopecorneredgeZMinus() : base("clayblockpink", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockpinkslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockpinkslopecorneredgeZPlus() : base("clayblockpink", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez+");
        }
    }
}