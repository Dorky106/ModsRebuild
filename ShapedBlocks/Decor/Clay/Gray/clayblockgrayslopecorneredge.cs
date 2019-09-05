using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgrayslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockgrayslopecorneredgeRecipe() : base("clayblockgrayslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgrayslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblockgrayslopecorneredge : DecorativeType
    {
        public clayblockgrayslopecorneredge() : base("clayblockgray", "slopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgrayslopecorneredge.png"))
        {
            this.SideAll = "clayblockgray";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgrayslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockgrayslopecorneredgeXMinus() : base("clayblockgray", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockgrayslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockgrayslopecorneredgeXPlus() : base("clayblockgray", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockgrayslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockgrayslopecorneredgeZMinus() : base("clayblockgray", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockgrayslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockgrayslopecorneredgeZPlus() : base("clayblockgray", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez+");
        }
    }
}