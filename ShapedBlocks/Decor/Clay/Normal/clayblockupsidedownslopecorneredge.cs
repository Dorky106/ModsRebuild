using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockupsidedownslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockupsidedownslopecorneredgeRecipe() : base("clayblockupsidedownslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockupsidedownslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblockupsidedownslopecorneredge : DecorativeType
    {
        public clayblockupsidedownslopecorneredge() : base("clayblock", "upsidedownslopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockupsidedownslopecorneredge.png"))
        {
            this.SideAll = "clayblock";
        }
    }

    [NCAPIType]
    public class clayblockupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockupsidedownslopecorneredgeXMinus() : base("clayblock", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockupsidedownslopecorneredgeXPlus() : base("clayblock", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockupsidedownslopecorneredgeZMinus() : base("clayblock", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockupsidedownslopecorneredgeZPlus() : base("clayblock", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez+");
        }
    }
}