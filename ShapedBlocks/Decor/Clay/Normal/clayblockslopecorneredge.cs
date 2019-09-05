using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockslopecorneredgeRecipe() : base("clayblockslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblockslopecorneredge : DecorativeType
    {
        public clayblockslopecorneredge() : base("clayblock", "slopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockslopecorneredge.png"))
        {
            this.SideAll = "clayblock";
        }
    }

    [NCAPIType]
    public class clayblockslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockslopecorneredgeXMinus() : base("clayblock", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockslopecorneredgeXPlus() : base("clayblock", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockslopecorneredgeZMinus() : base("clayblock", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockslopecorneredgeZPlus() : base("clayblock", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez+");
        }
    }
}