using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblueslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockblueslopecorneredgeRecipe() : base("clayblockblueslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblueslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblockblueslopecorneredge : DecorativeType
    {
        public clayblockblueslopecorneredge() : base("clayblockblue", "slopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblueslopecorneredge.png"))
        {
            this.SideAll = "clayblockblue";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblueslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockblueslopecorneredgeXMinus() : base("clayblockblue", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockblueslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockblueslopecorneredgeXPlus() : base("clayblockblue", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockblueslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockblueslopecorneredgeZMinus() : base("clayblockblue", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockblueslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockblueslopecorneredgeZPlus() : base("clayblockblue", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez+");
        }
    }
}