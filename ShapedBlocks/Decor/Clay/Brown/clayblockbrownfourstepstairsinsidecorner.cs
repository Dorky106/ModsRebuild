using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbrownfourstepstairsinsidecornerRecipe : BaseRecipe
    {
        public clayblockbrownfourstepstairsinsidecornerRecipe() : base("clayblockbrownfourstepstairsinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbrownfourstepstairsinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockbrownfourstepstairsinsidecorner : DecorativeType
    {
        public clayblockbrownfourstepstairsinsidecorner() : base("clayblockbrown", "fourstepstairsinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbrownfourstepstairsinsidecorner.png"))
        {
            this.SideAll = "clayblockbrown";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbrownfourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockbrownfourstepstairsinsidecornerXMinus() : base("clayblockbrown", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockbrownfourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockbrownfourstepstairsinsidecornerXPlus() : base("clayblockbrown", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockbrownfourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockbrownfourstepstairsinsidecornerZMinus() : base("clayblockbrown", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockbrownfourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockbrownfourstepstairsinsidecornerZPlus() : base("clayblockbrown", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz+");
        }
    }
}