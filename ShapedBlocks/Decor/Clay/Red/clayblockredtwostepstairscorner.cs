using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockredtwostepstairscornerRecipe : BaseRecipe
    {
        public clayblockredtwostepstairscornerRecipe() : base("clayblockredtwostepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockredtwostepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockredtwostepstairscorner : DecorativeType
    {
        public clayblockredtwostepstairscorner() : base("clayblockred", "twostepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockredtwostepstairscorner.png"))
        {
            this.SideAll = "clayblockred";
        }
    }

    [NCAPIType]
    public class clayblockredtwostepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockredtwostepstairscornerXMinus() : base("clayblockred", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockredtwostepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockredtwostepstairscornerXPlus() : base("clayblockred", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockredtwostepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockredtwostepstairscornerZMinus() : base("clayblockred", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockredtwostepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockredtwostepstairscornerZPlus() : base("clayblockred", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz+");
        }
    }
}