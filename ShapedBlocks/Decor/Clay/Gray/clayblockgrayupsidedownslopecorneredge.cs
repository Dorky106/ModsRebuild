using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgrayupsidedownslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockgrayupsidedownslopecorneredgeRecipe() : base("clayblockgrayupsidedownslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgrayupsidedownslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedownslopecorneredge : DecorativeType
    {
        public clayblockgrayupsidedownslopecorneredge() : base("clayblockgray", "upsidedownslopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgrayupsidedownslopecorneredge.png"))
        {
            this.SideAll = "clayblockgray";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockgrayupsidedownslopecorneredgeXMinus() : base("clayblockgray", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockgrayupsidedownslopecorneredgeXPlus() : base("clayblockgray", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockgrayupsidedownslopecorneredgeZMinus() : base("clayblockgray", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockgrayupsidedownslopecorneredgeZPlus() : base("clayblockgray", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez+");
        }
    }
}