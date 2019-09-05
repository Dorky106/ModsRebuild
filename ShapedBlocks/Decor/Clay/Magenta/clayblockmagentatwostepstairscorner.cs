using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockmagentatwostepstairscornerRecipe : BaseRecipe
    {
        public clayblockmagentatwostepstairscornerRecipe() : base("clayblockmagentatwostepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockmagentatwostepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockmagentatwostepstairscorner : DecorativeType
    {
        public clayblockmagentatwostepstairscorner() : base("clayblockmagenta", "twostepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockmagentatwostepstairscorner.png"))
        {
            this.SideAll = "clayblockmagenta";
        }
    }

    [NCAPIType]
    public class clayblockmagentatwostepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockmagentatwostepstairscornerXMinus() : base("clayblockmagenta", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockmagentatwostepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockmagentatwostepstairscornerXPlus() : base("clayblockmagenta", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockmagentatwostepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockmagentatwostepstairscornerZMinus() : base("clayblockmagenta", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockmagentatwostepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockmagentatwostepstairscornerZPlus() : base("clayblockmagenta", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz+");
        }
    }
}