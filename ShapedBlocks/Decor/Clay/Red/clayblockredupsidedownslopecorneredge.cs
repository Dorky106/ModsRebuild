using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockredupsidedownslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockredupsidedownslopecorneredgeRecipe() : base("clayblockredupsidedownslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockredupsidedownslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblockredupsidedownslopecorneredge : DecorativeType
    {
        public clayblockredupsidedownslopecorneredge() : base("clayblockred", "upsidedownslopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockredupsidedownslopecorneredge.png"))
        {
            this.SideAll = "clayblockred";
        }
    }

    [NCAPIType]
    public class clayblockredupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockredupsidedownslopecorneredgeXMinus() : base("clayblockred", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockredupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockredupsidedownslopecorneredgeXPlus() : base("clayblockred", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockredupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockredupsidedownslopecorneredgeZMinus() : base("clayblockred", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockredupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockredupsidedownslopecorneredgeZPlus() : base("clayblockred", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez+");
        }
    }
}