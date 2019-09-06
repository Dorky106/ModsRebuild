using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class bricksslopecorneredgeRecipe : BaseRecipe
    {
        public bricksslopecorneredgeRecipe() : base("bricksslopecorneredgerecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("bricks", 1));
            Result.Add(new InventoryItem("bricksslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class bricksslopecorneredge : DecorativeType
    {
        public bricksslopecorneredge() : base("bricks", "slopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "bricksslopecorneredge.png"))
        {
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
            this.SideAll = "bricks";
        }
    }

    [NCAPIType]
    public class bricksslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public bricksslopecorneredgeXMinus() : base("bricks", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex-");
        }
    }

    [NCAPIType]
    public class bricksslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public bricksslopecorneredgeXPlus() : base("bricks", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex+");
        }
    }

    [NCAPIType]
    public class bricksslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public bricksslopecorneredgeZMinus() : base("bricks", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez-");
        }
    }

    [NCAPIType]
    public class bricksslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public bricksslopecorneredgeZPlus() : base("bricks", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez+");
        }
    }
}