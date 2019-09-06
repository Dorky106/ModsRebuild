using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class bricksupsidedownslopecorneredgeRecipe : BaseRecipe
    {
        public bricksupsidedownslopecorneredgeRecipe() : base("bricksupsidedownslopecorneredgerecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("bricks", 1));
            Result.Add(new InventoryItem("bricksupsidedownslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class bricksupsidedownslopecorneredge : DecorativeType
    {
        public bricksupsidedownslopecorneredge() : base("bricks", "upsidedownslopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "bricksupsidedownslopecorneredge.png"))
        {
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
            this.SideAll = "bricks";
        }
    }

    [NCAPIType]
    public class bricksupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public bricksupsidedownslopecorneredgeXMinus() : base("bricks", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex-");
        }
    }

    [NCAPIType]
    public class bricksupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public bricksupsidedownslopecorneredgeXPlus() : base("bricks", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex+");
        }
    }

    [NCAPIType]
    public class bricksupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public bricksupsidedownslopecorneredgeZMinus() : base("bricks", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez-");
        }
    }

    [NCAPIType]
    public class bricksupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public bricksupsidedownslopecorneredgeZPlus() : base("bricks", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez+");
        }
    }
}