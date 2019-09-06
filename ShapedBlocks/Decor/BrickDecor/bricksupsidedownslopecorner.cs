using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class bricksupsidedownslopecornerRecipe : BaseRecipe
    {
        public bricksupsidedownslopecornerRecipe() : base("bricksupsidedownslopecornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("bricks", 1));
            Result.Add(new InventoryItem("bricksupsidedownslopecorner", 1));
        }
    }

    [NCAPIType]
    public class bricksupsidedownslopecorner : DecorativeType
    {
        public bricksupsidedownslopecorner() : base("bricks", "upsidedownslopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "bricksupsidedownslopecorner.png"))
        {
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
            this.SideAll = "bricks";
        }
    }

    [NCAPIType]
    public class bricksupsidedownslopecornerXMinus : DecorativeTypeXMinus
    {
        public bricksupsidedownslopecornerXMinus() : base("bricks", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx-");
        }
    }

    [NCAPIType]
    public class bricksupsidedownslopecornerXPlus : DecorativeTypeXPlus
    {
        public bricksupsidedownslopecornerXPlus() : base("bricks", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx+");
        }
    }

    [NCAPIType]
    public class bricksupsidedownslopecornerZMinus : DecorativeTypeZMinus
    {
        public bricksupsidedownslopecornerZMinus() : base("bricks", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz-");
        }
    }

    [NCAPIType]
    public class bricksupsidedownslopecornerZPlus : DecorativeTypeZPlus
    {
        public bricksupsidedownslopecornerZPlus() : base("bricks", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz+");
        }
    }
}