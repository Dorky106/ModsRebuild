using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgrayfourstepstairsinsidecornerRecipe : BaseRecipe
    {
        public clayblockgrayfourstepstairsinsidecornerRecipe() : base("clayblockgrayfourstepstairsinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgrayfourstepstairsinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockgrayfourstepstairsinsidecorner : DecorativeType
    {
        public clayblockgrayfourstepstairsinsidecorner() : base("clayblockgray", "fourstepstairsinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgrayfourstepstairsinsidecorner.png"))
        {
            this.SideAll = "clayblockgray";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgrayfourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockgrayfourstepstairsinsidecornerXMinus() : base("clayblockgray", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockgrayfourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockgrayfourstepstairsinsidecornerXPlus() : base("clayblockgray", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockgrayfourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockgrayfourstepstairsinsidecornerZMinus() : base("clayblockgray", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockgrayfourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockgrayfourstepstairsinsidecornerZPlus() : base("clayblockgray", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz+");
        }
    }
}