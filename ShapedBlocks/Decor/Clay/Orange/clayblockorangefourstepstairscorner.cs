using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class ClayblockorangefourstepstairscornerRecipe : BaseRecipe
    {
        public ClayblockorangefourstepstairscornerRecipe() : base("clayblockorangefourstepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockorangefourstepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class Clayblockorangefourstepstairscorner : DecorativeType
    {
        public Clayblockorangefourstepstairscorner() : base("clayblockorange", "fourstepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockorangefourstepstairscorner.png"))
        {
            this.SideAll = "clayblockorange";
        }
    }

    [NCAPIType]
    public class clayblockorangefourstepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockorangefourstepstairscornerXMinus() : base("clayblockorange", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockorangefourstepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockorangefourstepstairscornerXPlus() : base("clayblockorange", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockorangefourstepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockorangefourstepstairscornerZMinus() : base("clayblockorange", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockorangefourstepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockorangefourstepstairscornerZPlus() : base("clayblockorange", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz+");
        }
    }
}