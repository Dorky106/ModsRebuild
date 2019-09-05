using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocktwostepstairscornerRecipe : BaseRecipe
    {
        public clayblocktwostepstairscornerRecipe() : base("clayblocktwostepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocktwostepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocktwostepstairscorner : DecorativeType
    {
        public clayblocktwostepstairscorner() : base("clayblock", "twostepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocktwostepstairscorner.png"))
        {
            this.SideAll = "clayblock";
        }
    }

    [NCAPIType]
    public class clayblocktwostepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblocktwostepstairscornerXMinus() : base("clayblock", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblocktwostepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblocktwostepstairscornerXPlus() : base("clayblock", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblocktwostepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblocktwostepstairscornerZMinus() : base("clayblock", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblocktwostepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblocktwostepstairscornerZPlus() : base("clayblock", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz+");
        }
    }
}