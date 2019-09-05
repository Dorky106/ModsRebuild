using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockfourstepstairscornerRecipe : BaseRecipe
    {
        public clayblockfourstepstairscornerRecipe() : base("clayblockfourstepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockfourstepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockfourstepstairscorner : DecorativeType
    {
        public clayblockfourstepstairscorner() : base("clayblock", "fourstepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockfourstepstairscorner.png"))
        {
            this.SideAll = "clayblock";
        }
    }

    [NCAPIType]
    public class clayblockfourstepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockfourstepstairscornerXMinus() : base("clayblock", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockfourstepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockfourstepstairscornerXPlus() : base("clayblock", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockfourstepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockfourstepstairscornerZMinus() : base("clayblock", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockfourstepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockfourstepstairscornerZPlus() : base("clayblock", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz+");
        }
    }
}