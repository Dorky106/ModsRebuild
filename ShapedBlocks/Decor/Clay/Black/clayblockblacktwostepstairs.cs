using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblacktwostepstairsRecipe : BaseRecipe
    {
        public clayblockblacktwostepstairsRecipe() : base("clayblockblacktwostepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblacktwostepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockblacktwostepstairs : DecorativeType
    {
        public clayblockblacktwostepstairs() : base("clayblockblack", "twostepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblacktwostepstairs.png"))
        {
            this.SideAll = "clayblockblack";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblacktwostepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockblacktwostepstairsXMinus() : base("clayblockblack", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockblacktwostepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockblacktwostepstairsXPlus() : base("clayblockblack", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockblacktwostepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockblacktwostepstairsZMinus() : base("clayblockblack", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockblacktwostepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockblacktwostepstairsZPlus() : base("clayblockblack", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz+");
        }
    }
}