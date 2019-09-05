using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockmagentafourstepstairscornerRecipe : BaseRecipe
    {
        public clayblockmagentafourstepstairscornerRecipe() : base("clayblockmagentafourstepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockmagentafourstepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockmagentafourstepstairscorner : DecorativeType
    {
        public clayblockmagentafourstepstairscorner() : base("clayblockmagenta", "fourstepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockmagentafourstepstairscorner.png"))
        {
            this.SideAll = "clayblockmagenta";
        }
    }

    [NCAPIType]
    public class clayblockmagentafourstepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockmagentafourstepstairscornerXMinus() : base("clayblockmagenta", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockmagentafourstepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockmagentafourstepstairscornerXPlus() : base("clayblockmagenta", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockmagentafourstepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockmagentafourstepstairscornerZMinus() : base("clayblockmagenta", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockmagentafourstepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockmagentafourstepstairscornerZPlus() : base("clayblockmagenta", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz+");
        }
    }
}