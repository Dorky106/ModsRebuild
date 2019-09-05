using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class IronblockslopecorneredgeRecipe : BaseRecipe
    {
        public IronblockslopecorneredgeRecipe() : base("ironblockslopecorneredgerecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("ironblock", 1));
            Result.Add(new InventoryItem("ironblockslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class Ironblockslopecorneredge : DecorativeType
    {
        public Ironblockslopecorneredge() : base("ironblock", "slopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "ironblockslopecorneredge.png"))
        {
            this.SideAll = "ironblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class ironblockslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public ironblockslopecorneredgeXMinus() : base("ironblock", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex-");
        }
    }

    [NCAPIType]
    public class ironblockslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public ironblockslopecorneredgeXPlus() : base("ironblock", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex+");
        }
    }

    [NCAPIType]
    public class ironblockslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public ironblockslopecorneredgeZMinus() : base("ironblock", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez-");
        }
    }

    [NCAPIType]
    public class ironblockslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public ironblockslopecorneredgeZPlus() : base("ironblock", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez+");
        }
    }
}