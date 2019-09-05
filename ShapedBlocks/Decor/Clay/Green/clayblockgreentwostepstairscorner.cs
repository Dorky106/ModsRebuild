using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgreentwostepstairscornerRecipe : BaseRecipe
    {
        public clayblockgreentwostepstairscornerRecipe() : base("clayblockgreentwostepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgreentwostepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockgreentwostepstairscorner : DecorativeType
    {
        public clayblockgreentwostepstairscorner() : base("clayblockgreen", "twostepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgreentwostepstairscorner.png"))
        {
            this.SideAll = "clayblockgreen";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgreentwostepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockgreentwostepstairscornerXMinus() : base("clayblockgreen", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockgreentwostepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockgreentwostepstairscornerXPlus() : base("clayblockgreen", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockgreentwostepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockgreentwostepstairscornerZMinus() : base("clayblockgreen", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockgreentwostepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockgreentwostepstairscornerZPlus() : base("clayblockgreen", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz+");
        }
    }
}