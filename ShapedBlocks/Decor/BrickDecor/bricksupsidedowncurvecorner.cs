using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class bricksupsidedowncurvecornerRecipe : BaseRecipe
    {
        public bricksupsidedowncurvecornerRecipe() : base("bricksupsidedowncurvecornerrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("bricks", 1));
            Result.Add(new InventoryItem("bricksupsidedowncurvecorner", 1));
        }
    }

    [NCAPIType]
    public class bricksupsidedowncurvecorner : DecorativeType
    {
        public bricksupsidedowncurvecorner() : base("bricks", "upsidedowncurvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "bricksupsidedowncurvecorner.png"))
        {
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
            this.SideAll = "bricks";
        }
    }

    [NCAPIType]
    public class bricksupsidedowncurvecornerXMinus : DecorativeTypeXMinus
    {
        public bricksupsidedowncurvecornerXMinus() : base("bricks", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx-");
        }
    }

    [NCAPIType]
    public class bricksupsidedowncurvecornerXPlus : DecorativeTypeXPlus
    {
        public bricksupsidedowncurvecornerXPlus() : base("bricks", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx+");
        }
    }

    [NCAPIType]
    public class bricksupsidedowncurvecornerZMinus : DecorativeTypeZMinus
    {
        public bricksupsidedowncurvecornerZMinus() : base("bricks", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz-");
        }
    }

    [NCAPIType]
    public class bricksupsidedowncurvecornerZPlus : DecorativeTypeZPlus
    {
        public bricksupsidedowncurvecornerZPlus() : base("bricks", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz+");
        }
    }
}