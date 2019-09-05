using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgreentwostepstairsRecipe : BaseRecipe
    {
        public clayblockgreentwostepstairsRecipe() : base("clayblockgreentwostepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgreentwostepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockgreentwostepstairs : DecorativeType
    {
        public clayblockgreentwostepstairs() : base("clayblockgreen", "twostepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgreentwostepstairs.png"))
        {
            this.SideAll = "clayblockgreen";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgreentwostepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockgreentwostepstairsXMinus() : base("clayblockgreen", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockgreentwostepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockgreentwostepstairsXPlus() : base("clayblockgreen", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockgreentwostepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockgreentwostepstairsZMinus() : base("clayblockgreen", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockgreentwostepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockgreentwostepstairsZPlus() : base("clayblockgreen", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz+");
        }
    }
}