using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class brickstwostepstairsRecipe : BaseRecipe
    {
        public brickstwostepstairsRecipe() : base("brickstwostepstairsrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("bricks", 1));
            Result.Add(new InventoryItem("brickstwostepstairs", 1));
        }
    }

    [NCAPIType]
    public class brickstwostepstairs : DecorativeType
    {
        public brickstwostepstairs() : base("bricks", "twostepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "brickstwostepstairs.png"))
        {
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
            this.SideAll = "bricks";
        }
    }

    [NCAPIType]
    public class brickstwostepstairsXMinus : DecorativeTypeXMinus
    {
        public brickstwostepstairsXMinus() : base("bricks", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx-");
        }
    }

    [NCAPIType]
    public class brickstwostepstairsXPlus : DecorativeTypeXPlus
    {
        public brickstwostepstairsXPlus() : base("bricks", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx+");
        }
    }

    [NCAPIType]
    public class brickstwostepstairsZMinus : DecorativeTypeZMinus
    {
        public brickstwostepstairsZMinus() : base("bricks", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz-");
        }
    }

    [NCAPIType]
    public class brickstwostepstairsZPlus : DecorativeTypeZPlus
    {
        public brickstwostepstairsZPlus() : base("bricks", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz+");
        }
    }
}