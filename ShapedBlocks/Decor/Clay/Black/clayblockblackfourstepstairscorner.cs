using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblackfourstepstairscornerRecipe : BaseRecipe
    {
        public clayblockblackfourstepstairscornerRecipe() : base("clayblockblackfourstepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblackfourstepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockblackfourstepstairscorner : DecorativeType
    {
        public clayblockblackfourstepstairscorner() : base("clayblockblack", "fourstepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblackfourstepstairscorner.png"))
        {
            this.SideAll = "clayblockblack";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblackfourstepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockblackfourstepstairscornerXMinus() : base("clayblockblack", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockblackfourstepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockblackfourstepstairscornerXPlus() : base("clayblockblack", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockblackfourstepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockblackfourstepstairscornerZMinus() : base("clayblockblack", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockblackfourstepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockblackfourstepstairscornerZPlus() : base("clayblockblack", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz+");
        }
    }
}