using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgraytwostepstairsRecipe : BaseRecipe
    {
        public clayblockgraytwostepstairsRecipe() : base("clayblockgraytwostepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgraytwostepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockgraytwostepstairs : DecorativeType
    {
        public clayblockgraytwostepstairs() : base("clayblockgray", "twostepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgraytwostepstairs.png"))
        {
            this.SideAll = "clayblockgray";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgraytwostepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockgraytwostepstairsXMinus() : base("clayblockgray", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockgraytwostepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockgraytwostepstairsXPlus() : base("clayblockgray", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockgraytwostepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockgraytwostepstairsZMinus() : base("clayblockgray", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockgraytwostepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockgraytwostepstairsZPlus() : base("clayblockgray", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz+");
        }
    }
}