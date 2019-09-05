using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockmagentaupsidedownslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockmagentaupsidedownslopecorneredgeRecipe() : base("clayblockmagentaupsidedownslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockmagentaupsidedownslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedownslopecorneredge : DecorativeType
    {
        public clayblockmagentaupsidedownslopecorneredge() : base("clayblockmagenta", "upsidedownslopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockmagentaupsidedownslopecorneredge.png"))
        {
            this.SideAll = "clayblockmagenta";
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockmagentaupsidedownslopecorneredgeXMinus() : base("clayblockmagenta", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockmagentaupsidedownslopecorneredgeXPlus() : base("clayblockmagenta", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockmagentaupsidedownslopecorneredgeZMinus() : base("clayblockmagenta", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockmagentaupsidedownslopecorneredgeZPlus() : base("clayblockmagenta", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez+");
        }
    }
}