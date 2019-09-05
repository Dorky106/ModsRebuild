using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class brickscurvecornerRecipe : BaseRecipe
    {
        public brickscurvecornerRecipe() : base("brickscurvecornerrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("bricks", 1));
            Result.Add(new InventoryItem("brickscurvecorner", 1));
        }
    }

    [NCAPIType]
    public class brickscurvecorner : DecorativeType
    {
        public brickscurvecorner() : base("bricks", "curvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "brickscurvecorner.png"))
        {
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
            this.SideAll = "bricks";
        }
    }

    [NCAPIType]
    public class brickscurvecornerXMinus : DecorativeTypeXMinus
    {
        public brickscurvecornerXMinus() : base("bricks", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx-");
        }
    }

    [NCAPIType]
    public class brickscurvecornerXPlus : DecorativeTypeXPlus
    {
        public brickscurvecornerXPlus() : base("bricks", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx+");
        }
    }

    [NCAPIType]
    public class brickscurvecornerZMinus : DecorativeTypeZMinus
    {
        public brickscurvecornerZMinus() : base("bricks", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz-");
        }
    }

    [NCAPIType]
    public class brickscurvecornerZPlus : DecorativeTypeZPlus
    {
        public brickscurvecornerZPlus() : base("bricks", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz+");
        }
    }
}