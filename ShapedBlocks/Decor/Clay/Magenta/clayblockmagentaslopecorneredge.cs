using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockmagentaslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockmagentaslopecorneredgeRecipe() : base("clayblockmagentaslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockmagentaslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblockmagentaslopecorneredge : DecorativeType
    {
        public clayblockmagentaslopecorneredge() : base("clayblockmagenta", "slopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockmagentaslopecorneredge.png"))
        {
            this.SideAll = "clayblockmagenta";
        }
    }

    [NCAPIType]
    public class clayblockmagentaslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockmagentaslopecorneredgeXMinus() : base("clayblockmagenta", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockmagentaslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockmagentaslopecorneredgeXPlus() : base("clayblockmagenta", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockmagentaslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockmagentaslopecorneredgeZMinus() : base("clayblockmagenta", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockmagentaslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockmagentaslopecorneredgeZPlus() : base("clayblockmagenta", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez+");
        }
    }
}