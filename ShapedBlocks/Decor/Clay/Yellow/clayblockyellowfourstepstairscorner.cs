using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockyellowfourstepstairscornerRecipe : BaseRecipe
    {
        public clayblockyellowfourstepstairscornerRecipe() : base("clayblockyellowfourstepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockyellowfourstepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockyellowfourstepstairscorner : DecorativeType
    {
        public clayblockyellowfourstepstairscorner() : base("clayblockyellow", "fourstepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockyellowfourstepstairscorner.png"))
        {
            this.SideAll = "clayblockyellow";
        }
    }

    [NCAPIType]
    public class clayblockyellowfourstepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockyellowfourstepstairscornerXMinus() : base("clayblockyellow", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockyellowfourstepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockyellowfourstepstairscornerXPlus() : base("clayblockyellow", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockyellowfourstepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockyellowfourstepstairscornerZMinus() : base("clayblockyellow", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockyellowfourstepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockyellowfourstepstairscornerZPlus() : base("clayblockyellow", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz+");
        }
    }
}