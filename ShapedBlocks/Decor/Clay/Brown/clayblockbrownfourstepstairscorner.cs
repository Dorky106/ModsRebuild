using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbrownfourstepstairscornerRecipe : BaseRecipe
    {
        public clayblockbrownfourstepstairscornerRecipe() : base("clayblockbrownfourstepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbrownfourstepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockbrownfourstepstairscorner : DecorativeType
    {
        public clayblockbrownfourstepstairscorner() : base("clayblockbrown", "fourstepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbrownfourstepstairscorner.png"))
        {
            this.SideAll = "clayblockbrown";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbrownfourstepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockbrownfourstepstairscornerXMinus() : base("clayblockbrown", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockbrownfourstepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockbrownfourstepstairscornerXPlus() : base("clayblockbrown", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockbrownfourstepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockbrownfourstepstairscornerZMinus() : base("clayblockbrown", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockbrownfourstepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockbrownfourstepstairscornerZPlus() : base("clayblockbrown", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz+");
        }
    }
}