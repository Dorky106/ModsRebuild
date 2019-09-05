using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklimefourstepstairscornerRecipe : BaseRecipe
    {
        public clayblocklimefourstepstairscornerRecipe() : base("clayblocklimefourstepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklimefourstepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocklimefourstepstairscorner : DecorativeType
    {
        public clayblocklimefourstepstairscorner() : base("clayblocklime", "fourstepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklimefourstepstairscorner.png"))
        {
            this.SideAll = "clayblocklime";
        }
    }

    [NCAPIType]
    public class clayblocklimefourstepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblocklimefourstepstairscornerXMinus() : base("clayblocklime", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblocklimefourstepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblocklimefourstepstairscornerXPlus() : base("clayblocklime", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblocklimefourstepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblocklimefourstepstairscornerZMinus() : base("clayblocklime", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz-");
        }
    }

    [NCAPIType]
    public class ClayblocklimefourstepstairscornerZPlus : DecorativeTypeZPlus
    {
        public ClayblocklimefourstepstairscornerZPlus() : base("clayblocklime", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz+");
        }
    }
}