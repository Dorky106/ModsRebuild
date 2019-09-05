using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class plasterblockupsidedownslopecorneredgeRecipe : BaseRecipe
    {
        public plasterblockupsidedownslopecorneredgeRecipe() : base("plasterblockupsidedownslopecorneredgerecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("plasterblock", 1));
            Result.Add(new InventoryItem("plasterblockupsidedownslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class plasterblockupsidedownslopecorneredge : DecorativeType
    {
        public plasterblockupsidedownslopecorneredge() : base("plasterblock", "upsidedownslopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "plasterblockupsidedownslopecorneredge.png"))
        {
            this.SideAll = "plasterblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class plasterblockupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public plasterblockupsidedownslopecorneredgeXMinus() : base("plasterblock", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex-");
        }
    }

    [NCAPIType]
    public class plasterblockupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public plasterblockupsidedownslopecorneredgeXPlus() : base("plasterblock", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex+");
        }
    }

    [NCAPIType]
    public class plasterblockupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public plasterblockupsidedownslopecorneredgeZMinus() : base("plasterblock", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez-");
        }
    }

    [NCAPIType]
    public class plasterblockupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public plasterblockupsidedownslopecorneredgeZPlus() : base("plasterblock", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez+");
        }
    }
}