using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgreenslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockgreenslopecorneredgeRecipe() : base("clayblockgreenslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgreenslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblockgreenslopecorneredge : DecorativeType
    {
        public clayblockgreenslopecorneredge() : base("clayblockgreen", "slopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgreenslopecorneredge.png"))
        {
            this.SideAll = "clayblockgreen";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgreenslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockgreenslopecorneredgeXMinus() : base("clayblockgreen", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockgreenslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockgreenslopecorneredgeXPlus() : base("clayblockgreen", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockgreenslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockgreenslopecorneredgeZMinus() : base("clayblockgreen", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockgreenslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockgreenslopecorneredgeZPlus() : base("clayblockgreen", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez+");
        }
    }
}