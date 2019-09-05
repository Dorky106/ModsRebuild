using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockyellowslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockyellowslopecorneredgeRecipe() : base("clayblockyellowslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockyellowslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class Clayblockyellowslopecorneredge : DecorativeType
    {
        public Clayblockyellowslopecorneredge() : base("clayblockyellow", "slopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockyellowslopecorneredge.png"))
        {
            this.SideAll = "clayblockyellow";
        }
    }

    [NCAPIType]
    public class clayblockyellowslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockyellowslopecorneredgeXMinus() : base("clayblockyellow", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockyellowslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockyellowslopecorneredgeXPlus() : base("clayblockyellow", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockyellowslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockyellowslopecorneredgeZMinus() : base("clayblockyellow", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockyellowslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockyellowslopecorneredgeZPlus() : base("clayblockyellow", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez+");
        }
    }
}