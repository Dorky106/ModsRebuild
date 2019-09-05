using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbluetwostepstairscornerRecipe : BaseRecipe
    {
        public clayblockbluetwostepstairscornerRecipe() : base("clayblockbluetwostepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbluetwostepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockbluetwostepstairscorner : DecorativeType
    {
        public clayblockbluetwostepstairscorner() : base("clayblockblue", "twostepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbluetwostepstairscorner.png"))
        {
            this.SideAll = "clayblockblue";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbluetwostepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockbluetwostepstairscornerXMinus() : base("clayblockblue", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockbluetwostepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockbluetwostepstairscornerXPlus() : base("clayblockblue", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockbluetwostepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockbluetwostepstairscornerZMinus() : base("clayblockblue", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockbluetwostepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockbluetwostepstairscornerZPlus() : base("clayblockblue", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz+");
        }
    }
}