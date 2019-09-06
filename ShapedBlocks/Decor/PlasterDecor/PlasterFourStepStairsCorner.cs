using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class plasterblockfourstepstairscornerRecipe : BaseRecipe
    {
        public plasterblockfourstepstairscornerRecipe() : base("plasterblockfourstepstairscornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("plasterblock", 1));
            Result.Add(new InventoryItem("plasterblockfourstepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class plasterblockfourstepstairscorner : DecorativeType
    {
        public plasterblockfourstepstairscorner() : base("plasterblock", "fourstepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "plasterblockfourstepstairscorner.png"))
        {
            this.SideAll = "plasterblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class plasterblockfourstepstairscornerXMinus : DecorativeTypeXMinus
    {
        public plasterblockfourstepstairscornerXMinus() : base("plasterblock", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx-");
        }
    }

    [NCAPIType]
    public class plasterblockfourstepstairscornerXPlus : DecorativeTypeXPlus
    {
        public plasterblockfourstepstairscornerXPlus() : base("plasterblock", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx+");
        }
    }

    [NCAPIType]
    public class plasterblockfourstepstairscornerZMinus : DecorativeTypeZMinus
    {
        public plasterblockfourstepstairscornerZMinus() : base("plasterblock", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz-");
        }
    }

    [NCAPIType]
    public class plasterblockfourstepstairscornerZPlus : DecorativeTypeZPlus
    {
        public plasterblockfourstepstairscornerZPlus() : base("plasterblock", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz+");
        }
    }
}