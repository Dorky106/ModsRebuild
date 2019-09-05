using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblackfourstepstairsRecipe : BaseRecipe
    {
        public clayblockblackfourstepstairsRecipe() : base("clayblockblackfourstepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblackfourstepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockblackfourstepstairs : DecorativeType
    {
        public clayblockblackfourstepstairs() : base("clayblockblack", "fourstepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblackfourstepstairs.png"))
        {
            this.SideAll = "clayblockblack";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblackfourstepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockblackfourstepstairsXMinus() : base("clayblockblack", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockblackfourstepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockblackfourstepstairsXPlus() : base("clayblockblack", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockblackfourstepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockblackfourstepstairsZMinus() : base("clayblockblack", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockblackfourstepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockblackfourstepstairsZPlus() : base("clayblockblack", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}