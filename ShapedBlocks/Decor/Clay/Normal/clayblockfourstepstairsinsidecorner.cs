using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockfourstepstairsinsidecornerRecipe : BaseRecipe
    {
        public clayblockfourstepstairsinsidecornerRecipe() : base("clayblockfourstepstairsinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockfourstepstairsinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockfourstepstairsinsidecorner : DecorativeType
    {
        public clayblockfourstepstairsinsidecorner() : base("clayblock", "fourstepstairsinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockfourstepstairsinsidecorner.png"))
        {
            this.SideAll = "clayblock";
        }
    }

    [NCAPIType]
    public class clayblockfourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockfourstepstairsinsidecornerXMinus() : base("clayblock", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockfourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockfourstepstairsinsidecornerXPlus() : base("clayblock", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockfourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockfourstepstairsinsidecornerZMinus() : base("clayblock", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockfourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockfourstepstairsinsidecornerZPlus() : base("clayblock", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz+");
        }
    }
}