using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockorangeslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockorangeslopecorneredgeRecipe() : base("clayblockorangeslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockorangeslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblockorangeslopecorneredge : DecorativeType
    {
        public clayblockorangeslopecorneredge() : base("clayblockorange", "slopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockorangeslopecorneredge.png"))
        {
            this.SideAll = "clayblockorange";
        }
    }

    [NCAPIType]
    public class clayblockorangeslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockorangeslopecorneredgeXMinus() : base("clayblockorange", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockorangeslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockorangeslopecorneredgeXPlus() : base("clayblockorange", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockorangeslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockorangeslopecorneredgeZMinus() : base("clayblockorange", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockorangeslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockorangeslopecorneredgeZPlus() : base("clayblockorange", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez+");
        }
    }
}