using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class bricksfourstepstairsRecipe : BaseRecipe
    {
        public bricksfourstepstairsRecipe() : base("bricksfourstepstairsrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("bricks", 1));
            Result.Add(new InventoryItem("bricksfourstepstairs", 1));
        }
    }

    [NCAPIType]
    public class bricksfourstepstairs : DecorativeType
    {
        public bricksfourstepstairs() : base("bricks", "fourstepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "bricksfourstepstairs.png"))
        {
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
            this.SideAll = "bricks";
        }
    }

    [NCAPIType]
    public class bricksfourstepstairsXMinus : DecorativeTypeXMinus
    {
        public bricksfourstepstairsXMinus() : base("bricks", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class bricksfourstepstairsXPlus : DecorativeTypeXPlus
    {
        public bricksfourstepstairsXPlus() : base("bricks", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class bricksfourstepstairsZMinus : DecorativeTypeZMinus
    {
        public bricksfourstepstairsZMinus() : base("bricks", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class bricksfourstepstairsZPlus : DecorativeTypeZPlus
    {
        public bricksfourstepstairsZPlus() : base("bricks", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}