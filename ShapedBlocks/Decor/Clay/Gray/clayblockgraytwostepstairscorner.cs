using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgraytwostepstairscornerRecipe : BaseRecipe
    {
        public clayblockgraytwostepstairscornerRecipe() : base("clayblockgraytwostepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgraytwostepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockgraytwostepstairscorner : DecorativeType
    {
        public clayblockgraytwostepstairscorner() : base("clayblockgray", "twostepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgraytwostepstairscorner.png"))
        {
            this.SideAll = "clayblockgray";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgraytwostepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockgraytwostepstairscornerXMinus() : base("clayblockgray", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockgraytwostepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockgraytwostepstairscornerXPlus() : base("clayblockgray", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockgraytwostepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockgraytwostepstairscornerZMinus() : base("clayblockgray", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockgraytwostepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockgraytwostepstairscornerZPlus() : base("clayblockgray", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz+");
        }
    }
}