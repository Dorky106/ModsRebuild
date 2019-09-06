using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class plasterblockfourstepstairsinsidecornerRecipe : BaseRecipe
    {
        public plasterblockfourstepstairsinsidecornerRecipe() : base("plasterblockfourstepstairsinsidecornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("plasterblock", 1));
            Result.Add(new InventoryItem("plasterblockfourstepstairsinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class plasterblockfourstepstairsinsidecorner : DecorativeType
    {
        public plasterblockfourstepstairsinsidecorner() : base("plasterblock", "fourstepstairsinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "plasterblockfourstepstairsinsidecorner.png"))
        {
            this.SideAll = "plasterblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class plasterblockfourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
    {
        public plasterblockfourstepstairsinsidecornerXMinus() : base("plasterblock", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx-");
        }
    }

    [NCAPIType]
    public class plasterblockfourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
    {
        public plasterblockfourstepstairsinsidecornerXPlus() : base("plasterblock", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx+");
        }
    }

    [NCAPIType]
    public class plasterblockfourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
    {
        public plasterblockfourstepstairsinsidecornerZMinus() : base("plasterblock", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz-");
        }
    }

    [NCAPIType]
    public class plasterblockfourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
    {
        public plasterblockfourstepstairsinsidecornerZPlus() : base("plasterblock", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz+");
        }
    }
}