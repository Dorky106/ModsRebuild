using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbluetwostepstairsRecipe : BaseRecipe
    {
        public clayblockbluetwostepstairsRecipe() : base("clayblockbluetwostepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbluetwostepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockbluetwostepstairs : DecorativeType
    {
        public clayblockbluetwostepstairs() : base("clayblockblue", "twostepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbluetwostepstairs.png"))
        {
            this.SideAll = "clayblockblue";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbluetwostepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockbluetwostepstairsXMinus() : base("clayblockblue", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockbluetwostepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockbluetwostepstairsXPlus() : base("clayblockblue", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockbluetwostepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockbluetwostepstairsZMinus() : base("clayblockblue", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockbluetwostepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockbluetwostepstairsZPlus() : base("clayblockblue", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz+");
        }
    }
}