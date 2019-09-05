using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklightbluefourstepstairscornerRecipe : BaseRecipe
    {
        public clayblocklightbluefourstepstairscornerRecipe() : base("clayblocklightbluefourstepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklightbluefourstepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocklightbluefourstepstairscorner : DecorativeType
    {
        public clayblocklightbluefourstepstairscorner() : base("clayblocklightblue", "fourstepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklightbluefourstepstairscorner.png"))
        {
            this.SideAll = "clayblocklightblue";
        }
    }

    [NCAPIType]
    public class clayblocklightbluefourstepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblocklightbluefourstepstairscornerXMinus() : base("clayblocklightblue", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblocklightbluefourstepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblocklightbluefourstepstairscornerXPlus() : base("clayblocklightblue", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblocklightbluefourstepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblocklightbluefourstepstairscornerZMinus() : base("clayblocklightblue", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblocklightbluefourstepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblocklightbluefourstepstairscornerZPlus() : base("clayblocklightblue", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz+");
        }
    }
}