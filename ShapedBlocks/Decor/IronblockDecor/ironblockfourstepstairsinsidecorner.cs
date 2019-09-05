using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class ironblockfourstepstairsinsidecornerRecipe : BaseRecipe
    {
        public ironblockfourstepstairsinsidecornerRecipe() : base("ironblockfourstepstairsinsidecornerrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("ironblock", 1));
            Result.Add(new InventoryItem("ironblockfourstepstairsinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class ironblockfourstepstairsinsidecorner : DecorativeType
    {
        public ironblockfourstepstairsinsidecorner() : base("ironblock", "fourstepstairsinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "ironblockfourstepstairsinsidecorner.png"))
        {
            this.SideAll = "ironblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class ironblockfourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
    {
        public ironblockfourstepstairsinsidecornerXMinus() : base("ironblock", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx-");
        }
    }

    [NCAPIType]
    public class ironblockfourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
    {
        public ironblockfourstepstairsinsidecornerXPlus() : base("ironblock", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx+");
        }
    }

    [NCAPIType]
    public class ironblockfourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
    {
        public ironblockfourstepstairsinsidecornerZMinus() : base("ironblock", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz-");
        }
    }

    [NCAPIType]
    public class ironblockfourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
    {
        public ironblockfourstepstairsinsidecornerZPlus() : base("ironblock", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz+");
        }
    }
}