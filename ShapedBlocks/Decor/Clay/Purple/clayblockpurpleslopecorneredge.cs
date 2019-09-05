using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpurpleslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockpurpleslopecorneredgeRecipe() : base("clayblockpurpleslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpurpleslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class Clayblockpurpleslopecorneredge : DecorativeType
    {
        public Clayblockpurpleslopecorneredge() : base("clayblockpurple", "slopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpurpleslopecorneredge.png"))
        {
            this.SideAll = "clayblockpurple";
        }
    }

    [NCAPIType]
    public class clayblockpurpleslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockpurpleslopecorneredgeXMinus() : base("clayblockpurple", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockpurpleslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockpurpleslopecorneredgeXPlus() : base("clayblockpurple", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockpurpleslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockpurpleslopecorneredgeZMinus() : base("clayblockpurple", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockpurpleslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockpurpleslopecorneredgeZPlus() : base("clayblockpurple", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez+");
        }
    }
}