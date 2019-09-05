using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockredslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockredslopecorneredgeRecipe() : base("clayblockredslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockredslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblockredslopecorneredge : DecorativeType
    {
        public clayblockredslopecorneredge() : base("clayblockred", "slopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockredslopecorneredge.png"))
        {
            this.SideAll = "clayblockred";
        }
    }

    [NCAPIType]
    public class clayblockredslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockredslopecorneredgeXMinus() : base("clayblockred", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockredslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockredslopecorneredgeXPlus() : base("clayblockred", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockredslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockredslopecorneredgeZMinus() : base("clayblockred", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockredslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockredslopecorneredgeZPlus() : base("clayblockred", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez+");
        }
    }
}