using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class brickstwostepstairscornerRecipe : BaseRecipe
    {
        public brickstwostepstairscornerRecipe() : base("brickstwostepstairscornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("bricks", 1));
            Result.Add(new InventoryItem("brickstwostepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class brickstwostepstairscorner : DecorativeType
    {
        public brickstwostepstairscorner() : base("bricks", "twostepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "brickstwostepstairscorner.png"))
        {
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
            this.SideAll = "bricks";
        }
    }

    [NCAPIType]
    public class brickstwostepstairscornerXMinus : DecorativeTypeXMinus
    {
        public brickstwostepstairscornerXMinus() : base("bricks", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx-");
        }
    }

    [NCAPIType]
    public class brickstwostepstairscornerXPlus : DecorativeTypeXPlus
    {
        public brickstwostepstairscornerXPlus() : base("bricks", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx+");
        }
    }

    [NCAPIType]
    public class brickstwostepstairscornerZMinus : DecorativeTypeZMinus
    {
        public brickstwostepstairscornerZMinus() : base("bricks", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz-");
        }
    }

    [NCAPIType]
    public class brickstwostepstairscornerZPlus : DecorativeTypeZPlus
    {
        public brickstwostepstairscornerZPlus() : base("bricks", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz+");
        }
    }
}