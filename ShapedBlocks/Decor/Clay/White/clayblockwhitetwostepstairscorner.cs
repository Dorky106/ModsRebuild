using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockwhitetwostepstairscornerRecipe : BaseRecipe
    {
        public clayblockwhitetwostepstairscornerRecipe() : base("clayblockwhitetwostepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockwhitetwostepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockwhitetwostepstairscorner : DecorativeType
    {
        public clayblockwhitetwostepstairscorner() : base("clayblockwhite", "twostepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockwhitetwostepstairscorner.png"))
        {
            this.SideAll = "clayblockwhite";
        }
    }

    [NCAPIType]
    public class clayblockwhitetwostepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockwhitetwostepstairscornerXMinus() : base("clayblockwhite", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockwhitetwostepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockwhitetwostepstairscornerXPlus() : base("clayblockwhite", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockwhitetwostepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockwhitetwostepstairscornerZMinus() : base("clayblockwhite", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockwhitetwostepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockwhitetwostepstairscornerZPlus() : base("clayblockwhite", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz+");
        }
    }
}