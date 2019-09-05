using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgrayfourstepstairscornerRecipe : BaseRecipe
    {
        public clayblockgrayfourstepstairscornerRecipe() : base("clayblockgrayfourstepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgrayfourstepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockgrayfourstepstairscorner : DecorativeType
    {
        public clayblockgrayfourstepstairscorner() : base("clayblockgray", "fourstepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgrayfourstepstairscorner.png"))
        {
            this.SideAll = "clayblockgray";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgrayfourstepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockgrayfourstepstairscornerXMinus() : base("clayblockgray", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockgrayfourstepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockgrayfourstepstairscornerXPlus() : base("clayblockgray", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockgrayfourstepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockgrayfourstepstairscornerZMinus() : base("clayblockgray", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockgrayfourstepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockgrayfourstepstairscornerZPlus() : base("clayblockgray", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz+");
        }
    }
}