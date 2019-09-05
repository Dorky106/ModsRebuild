using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgreenupsidedownslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockgreenupsidedownslopecorneredgeRecipe() : base("clayblockgreenupsidedownslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgreenupsidedownslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedownslopecorneredge : DecorativeType
    {
        public clayblockgreenupsidedownslopecorneredge() : base("clayblockgreen", "upsidedownslopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgreenupsidedownslopecorneredge.png"))
        {
            this.SideAll = "clayblockgreen";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockgreenupsidedownslopecorneredgeXMinus() : base("clayblockgreen", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockgreenupsidedownslopecorneredgeXPlus() : base("clayblockgreen", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockgreenupsidedownslopecorneredgeZMinus() : base("clayblockgreen", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockgreenupsidedownslopecorneredgeZPlus() : base("clayblockgreen", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez+");
        }
    }
}