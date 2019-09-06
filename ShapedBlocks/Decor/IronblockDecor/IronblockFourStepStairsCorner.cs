using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class ironblockfourstepstairscornerRecipe : BaseRecipe
    {
        public ironblockfourstepstairscornerRecipe() : base("ironblockfourstepstairscornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("ironblock", 1));
            Result.Add(new InventoryItem("ironblockfourstepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class ironblockfourstepstairscorner : DecorativeType
    {
        public ironblockfourstepstairscorner() : base("ironblock", "fourstepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "ironblockfourstepstairscorner.png"))
        {
            this.SideAll = "ironblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class ironblockfourstepstairscornerXMinus : DecorativeTypeXMinus
    {
        public ironblockfourstepstairscornerXMinus() : base("ironblock", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx-");
        }
    }

    [NCAPIType]
    public class ironblockfourstepstairscornerXPlus : DecorativeTypeXPlus
    {
        public ironblockfourstepstairscornerXPlus() : base("ironblock", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx+");
        }
    }

    [NCAPIType]
    public class ironblockfourstepstairscornerZMinus : DecorativeTypeZMinus
    {
        public ironblockfourstepstairscornerZMinus() : base("ironblock", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz-");
        }
    }

    [NCAPIType]
    public class ironblockfourstepstairscornerZPlus : DecorativeTypeZPlus
    {
        public ironblockfourstepstairscornerZPlus() : base("ironblock", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz+");
        }
    }
}