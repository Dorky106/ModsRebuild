using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbrowntwostepstairsRecipe : BaseRecipe
    {
        public clayblockbrowntwostepstairsRecipe() : base("clayblockbrowntwostepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbrowntwostepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockbrowntwostepstairs : DecorativeType
    {
        public clayblockbrowntwostepstairs() : base("clayblockbrown", "twostepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbrowntwostepstairs.png"))
        {
            this.SideAll = "clayblockbrown";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbrowntwostepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockbrowntwostepstairsXMinus() : base("clayblockbrown", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockbrowntwostepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockbrowntwostepstairsXPlus() : base("clayblockbrown", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockbrowntwostepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockbrowntwostepstairsZMinus() : base("clayblockbrown", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockbrowntwostepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockbrowntwostepstairsZPlus() : base("clayblockbrown", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz+");
        }
    }
}