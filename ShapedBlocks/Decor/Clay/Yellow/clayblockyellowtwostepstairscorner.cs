using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockyellowtwostepstairscornerRecipe : BaseRecipe
    {
        public clayblockyellowtwostepstairscornerRecipe() : base("clayblockyellowtwostepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockyellowtwostepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockyellowtwostepstairscorner : DecorativeType
    {
        public clayblockyellowtwostepstairscorner() : base("clayblockyellow", "twostepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockyellowtwostepstairscorner.png"))
        {
            this.SideAll = "clayblockyellow";
        }
    }

    [NCAPIType]
    public class clayblockyellowtwostepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockyellowtwostepstairscornerXMinus() : base("clayblockyellow", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockyellowtwostepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockyellowtwostepstairscornerXPlus() : base("clayblockyellow", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockyellowtwostepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockyellowtwostepstairscornerZMinus() : base("clayblockyellow", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockyellowtwostepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockyellowtwostepstairscornerZPlus() : base("clayblockyellow", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz+");
        }
    }
}