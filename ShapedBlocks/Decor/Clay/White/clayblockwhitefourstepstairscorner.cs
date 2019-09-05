using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockwhitefourstepstairscornerRecipe : BaseRecipe
    {
        public clayblockwhitefourstepstairscornerRecipe() : base("clayblockwhitefourstepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockwhitefourstepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockwhitefourstepstairscorner : DecorativeType
    {
        public clayblockwhitefourstepstairscorner() : base("clayblockwhite", "fourstepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockwhitefourstepstairscorner.png"))
        {
            this.SideAll = "clayblockwhite";
        }
    }

    [NCAPIType]
    public class clayblockwhitefourstepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockwhitefourstepstairscornerXMinus() : base("clayblockwhite", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockwhitefourstepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockwhitefourstepstairscornerXPlus() : base("clayblockwhite", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockwhitefourstepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockwhitefourstepstairscornerZMinus() : base("clayblockwhite", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockwhitefourstepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockwhitefourstepstairscornerZPlus() : base("clayblockwhite", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz+");
        }
    }
}