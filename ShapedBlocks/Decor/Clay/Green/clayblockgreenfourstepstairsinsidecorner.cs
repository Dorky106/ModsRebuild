using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgreenfourstepstairsinsidecornerRecipe : BaseRecipe
    {
        public clayblockgreenfourstepstairsinsidecornerRecipe() : base("clayblockgreenfourstepstairsinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgreenfourstepstairsinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockgreenfourstepstairsinsidecorner : DecorativeType
    {
        public clayblockgreenfourstepstairsinsidecorner() : base("clayblockgreen", "fourstepstairsinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgreenfourstepstairsinsidecorner.png"))
        {
            this.SideAll = "clayblockgreen";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgreenfourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockgreenfourstepstairsinsidecornerXMinus() : base("clayblockgreen", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockgreenfourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockgreenfourstepstairsinsidecornerXPlus() : base("clayblockgreen", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockgreenfourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockgreenfourstepstairsinsidecornerZMinus() : base("clayblockgreen", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockgreenfourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockgreenfourstepstairsinsidecornerZPlus() : base("clayblockgreen", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz+");
        }
    }
}