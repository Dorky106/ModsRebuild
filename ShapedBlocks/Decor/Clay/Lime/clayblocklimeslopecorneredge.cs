using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklimeslopecorneredgeRecipe : BaseRecipe
    {
        public clayblocklimeslopecorneredgeRecipe() : base("clayblocklimeslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklimeslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblocklimeslopecorneredge : DecorativeType
    {
        public clayblocklimeslopecorneredge() : base("clayblocklime", "slopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklimeslopecorneredge.png"))
        {
            this.SideAll = "clayblocklime";
        }
    }

    [NCAPIType]
    public class clayblocklimeslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblocklimeslopecorneredgeXMinus() : base("clayblocklime", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblocklimeslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblocklimeslopecorneredgeXPlus() : base("clayblocklime", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblocklimeslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblocklimeslopecorneredgeZMinus() : base("clayblocklime", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblocklimeslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblocklimeslopecorneredgeZPlus() : base("clayblocklime", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez+");
        }
    }
}