using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklimetwostepstairscornerRecipe : BaseRecipe
    {
        public clayblocklimetwostepstairscornerRecipe() : base("clayblocklimetwostepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklimetwostepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocklimetwostepstairscorner : DecorativeType
    {
        public clayblocklimetwostepstairscorner() : base("clayblocklime", "twostepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklimetwostepstairscorner.png"))
        {
            this.SideAll = "clayblocklime";
        }
    }

    [NCAPIType]
    public class clayblocklimetwostepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblocklimetwostepstairscornerXMinus() : base("clayblocklime", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblocklimetwostepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblocklimetwostepstairscornerXPlus() : base("clayblocklime", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblocklimetwostepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblocklimetwostepstairscornerZMinus() : base("clayblocklime", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblocklimetwostepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblocklimetwostepstairscornerZPlus() : base("clayblocklime", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz+");
        }
    }
}