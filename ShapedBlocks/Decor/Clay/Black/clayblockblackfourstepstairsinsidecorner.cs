using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblackfourstepstairsinsidecornerRecipe : BaseRecipe
    {
        public clayblockblackfourstepstairsinsidecornerRecipe() : base("clayblockblackfourstepstairsinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblackfourstepstairsinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockblackfourstepstairsinsidecorner : DecorativeType
    {
        public clayblockblackfourstepstairsinsidecorner() : base("clayblockblack", "fourstepstairsinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblackfourstepstairsinsidecorner.png"))
        {
            this.SideAll = "clayblockblack";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblackfourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockblackfourstepstairsinsidecornerXMinus() : base("clayblockblack", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockblackfourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockblackfourstepstairsinsidecornerXPlus() : base("clayblockblack", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockblackfourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockblackfourstepstairsinsidecornerZMinus() : base("clayblockblack", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockblackfourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockblackfourstepstairsinsidecornerZPlus() : base("clayblockblack", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz+");
        }
    }
}