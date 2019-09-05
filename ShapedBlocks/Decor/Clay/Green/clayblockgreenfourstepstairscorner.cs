using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgreenfourstepstairscornerRecipe : BaseRecipe
    {
        public clayblockgreenfourstepstairscornerRecipe() : base("clayblockgreenfourstepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgreenfourstepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockgreenfourstepstairscorner : DecorativeType
    {
        public clayblockgreenfourstepstairscorner() : base("clayblockgreen", "fourstepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgreenfourstepstairscorner.png"))
        {
            this.SideAll = "clayblockgreen";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgreenfourstepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockgreenfourstepstairscornerXMinus() : base("clayblockgreen", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockgreenfourstepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockgreenfourstepstairscornerXPlus() : base("clayblockgreen", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockgreenfourstepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockgreenfourstepstairscornerZMinus() : base("clayblockgreen", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockgreenfourstepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockgreenfourstepstairscornerZPlus() : base("clayblockgreen", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz+");
        }
    }
}