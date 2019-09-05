using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbrownfourstepstairsRecipe : BaseRecipe
    {
        public clayblockbrownfourstepstairsRecipe() : base("clayblockbrownfourstepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbrownfourstepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockbrownfourstepstairs : DecorativeType
    {
        public clayblockbrownfourstepstairs() : base("clayblockbrown", "fourstepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbrownfourstepstairs.png"))
        {
            this.SideAll = "clayblockbrown";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbrownfourstepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockbrownfourstepstairsXMinus() : base("clayblockbrown", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockbrownfourstepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockbrownfourstepstairsXPlus() : base("clayblockbrown", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockbrownfourstepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockbrownfourstepstairsZMinus() : base("clayblockbrown", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockbrownfourstepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockbrownfourstepstairsZPlus() : base("clayblockbrown", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}