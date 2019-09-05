using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblueupsidedownslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockblueupsidedownslopecorneredgeRecipe() : base("clayblockblueupsidedownslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblueupsidedownslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedownslopecorneredge : DecorativeType
    {
        public clayblockblueupsidedownslopecorneredge() : base("clayblockblue", "upsidedownslopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblueupsidedownslopecorneredge.png"))
        {
            this.SideAll = "clayblockblue";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockblueupsidedownslopecorneredgeXMinus() : base("clayblockblue", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockblueupsidedownslopecorneredgeXPlus() : base("clayblockblue", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockblueupsidedownslopecorneredgeZMinus() : base("clayblockblue", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockblueupsidedownslopecorneredgeZPlus() : base("clayblockblue", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez+");
        }
    }
}