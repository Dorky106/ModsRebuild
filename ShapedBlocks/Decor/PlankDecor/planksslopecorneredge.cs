using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class PlanksslopecorneredgeRecipe : BaseRecipe
    {
        public PlanksslopecorneredgeRecipe() : base("planksslopecorneredgerecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("planks", 1));
            Result.Add(new InventoryItem("planksslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class Planksslopecorneredge : DecorativeType
    {
        public Planksslopecorneredge() : base("planks", "slopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "planksslopecorneredge.png"))
        {
            this.SideAll = "planks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class planksslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public planksslopecorneredgeXMinus() : base("planks", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex-");
        }
    }

    [NCAPIType]
    public class planksslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public planksslopecorneredgeXPlus() : base("planks", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex+");
        }
    }

    [NCAPIType]
    public class planksslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public planksslopecorneredgeZMinus() : base("planks", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez-");
        }
    }

    [NCAPIType]
    public class planksslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public planksslopecorneredgeZPlus() : base("planks", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez+");
        }
    }
}