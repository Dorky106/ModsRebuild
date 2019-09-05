using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbrowntwostepstairscornerRecipe : BaseRecipe
    {
        public clayblockbrowntwostepstairscornerRecipe() : base("clayblockbrowntwostepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbrowntwostepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockbrowntwostepstairscorner : DecorativeType
    {
        public clayblockbrowntwostepstairscorner() : base("clayblockbrown", "twostepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbrowntwostepstairscorner.png"))
        {
            this.SideAll = "clayblockbrown";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbrowntwostepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockbrowntwostepstairscornerXMinus() : base("clayblockbrown", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockbrowntwostepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockbrowntwostepstairscornerXPlus() : base("clayblockbrown", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockbrowntwostepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockbrowntwostepstairscornerZMinus() : base("clayblockbrown", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockbrowntwostepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockbrowntwostepstairscornerZPlus() : base("clayblockbrown", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz+");
        }
    }
}