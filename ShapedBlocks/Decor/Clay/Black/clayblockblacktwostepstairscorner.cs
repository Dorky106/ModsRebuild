using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblacktwostepstairscornerRecipe : BaseRecipe
    {
        public clayblockblacktwostepstairscornerRecipe() : base("clayblockblacktwostepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblacktwostepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockblacktwostepstairscorner : DecorativeType
    {
        public clayblockblacktwostepstairscorner() : base("clayblockblack", "twostepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblacktwostepstairscorner.png"))
        {
            this.SideAll = "clayblockblack";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblacktwostepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockblacktwostepstairscornerXMinus() : base("clayblockblack", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockblacktwostepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockblacktwostepstairscornerXPlus() : base("clayblockblack", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockblacktwostepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockblacktwostepstairscornerZMinus() : base("clayblockblack", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockblacktwostepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockblacktwostepstairscornerZPlus() : base("clayblockblack", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz+");
        }
    }
}