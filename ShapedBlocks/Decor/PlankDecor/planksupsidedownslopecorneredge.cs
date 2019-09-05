using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class planksupsidedownslopecorneredgeRecipe : BaseRecipe
    {
        public planksupsidedownslopecorneredgeRecipe() : base("planksupsidedownslopecorneredgerecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("planks", 1));
            Result.Add(new InventoryItem("planksupsidedownslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class planksupsidedownslopecorneredge : DecorativeType
    {
        public planksupsidedownslopecorneredge() : base("planks", "upsidedownslopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "planksupsidedownslopecorneredge.png"))
        {
            this.SideAll = "planks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class planksupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public planksupsidedownslopecorneredgeXMinus() : base("planks", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex-");
        }
    }

    [NCAPIType]
    public class planksupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public planksupsidedownslopecorneredgeXPlus() : base("planks", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex+");
        }
    }

    [NCAPIType]
    public class planksupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public planksupsidedownslopecorneredgeZMinus() : base("planks", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez-");
        }
    }

    [NCAPIType]
    public class planksupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public planksupsidedownslopecorneredgeZPlus() : base("planks", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez+");
        }
    }
}