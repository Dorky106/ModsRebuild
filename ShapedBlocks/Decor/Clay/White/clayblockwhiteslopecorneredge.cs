using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class ClayblockwhiteslopecorneredgeRecipe : BaseRecipe
    {
        public ClayblockwhiteslopecorneredgeRecipe() : base("clayblockwhiteslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockwhiteslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblockwhiteslopecorneredge : DecorativeType
    {
        public clayblockwhiteslopecorneredge() : base("clayblockwhite", "slopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockwhiteslopecorneredge.png"))
        {
            this.SideAll = "clayblockwhite";
        }
    }

    [NCAPIType]
    public class clayblockwhiteslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockwhiteslopecorneredgeXMinus() : base("clayblockwhite", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockwhiteslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockwhiteslopecorneredgeXPlus() : base("clayblockwhite", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockwhiteslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockwhiteslopecorneredgeZMinus() : base("clayblockwhite", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockwhiteslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockwhiteslopecorneredgeZPlus() : base("clayblockwhite", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez+");
        }
    }
}