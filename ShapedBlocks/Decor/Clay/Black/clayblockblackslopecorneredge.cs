using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblackslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockblackslopecorneredgeRecipe() : base("clayblockblackslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblackslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblockblackslopecorneredge : DecorativeType
    {
        public clayblockblackslopecorneredge() : base("clayblockblack", "slopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblackslopecorneredge.png"))
        {
            this.SideAll = "clayblockblack";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblackslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockblackslopecorneredgeXMinus() : base("clayblockblack", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockblackslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockblackslopecorneredgeXPlus() : base("clayblockblack", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockblackslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockblackslopecorneredgeZMinus() : base("clayblockblack", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockblackslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockblackslopecorneredgeZPlus() : base("clayblockblack", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez+");
        }
    }
}