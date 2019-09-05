using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbrownslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockbrownslopecorneredgeRecipe() : base("clayblockbrownslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbrownslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblockbrownslopecorneredge : DecorativeType
    {
        public clayblockbrownslopecorneredge() : base("clayblockbrown", "slopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbrownslopecorneredge.png"))
        {
            this.SideAll = "clayblockbrown";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbrownslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockbrownslopecorneredgeXMinus() : base("clayblockbrown", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockbrownslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockbrownslopecorneredgeXPlus() : base("clayblockbrown", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockbrownslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockbrownslopecorneredgeZMinus() : base("clayblockbrown", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockbrownslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockbrownslopecorneredgeZPlus() : base("clayblockbrown", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez+");
        }
    }
}