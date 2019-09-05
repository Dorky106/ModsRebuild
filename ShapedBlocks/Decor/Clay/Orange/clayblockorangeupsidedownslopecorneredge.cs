using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockorangeupsidedownslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockorangeupsidedownslopecorneredgeRecipe() : base("clayblockorangeupsidedownslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockorangeupsidedownslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedownslopecorneredge : DecorativeType
    {
        public clayblockorangeupsidedownslopecorneredge() : base("clayblockorange", "upsidedownslopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockorangeupsidedownslopecorneredge.png"))
        {
            this.SideAll = "clayblockorange";
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockorangeupsidedownslopecorneredgeXMinus() : base("clayblockorange", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockorangeupsidedownslopecorneredgeXPlus() : base("clayblockorange", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockorangeupsidedownslopecorneredgeZMinus() : base("clayblockorange", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockorangeupsidedownslopecorneredgeZPlus() : base("clayblockorange", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez+");
        }
    }
}