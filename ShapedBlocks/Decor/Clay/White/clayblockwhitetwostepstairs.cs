using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockwhitetwostepstairsRecipe : BaseRecipe
    {
        public clayblockwhitetwostepstairsRecipe() : base("clayblockwhitetwostepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockwhitetwostepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockwhitetwostepstairs : DecorativeType
    {
        public clayblockwhitetwostepstairs() : base("clayblockwhite", "twostepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockwhitetwostepstairs.png"))
        {
            this.SideAll = "clayblockwhite";
        }
    }

    [NCAPIType]
    public class clayblockwhitetwostepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockwhitetwostepstairsXMinus() : base("clayblockwhite", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockwhitetwostepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockwhitetwostepstairsXPlus() : base("clayblockwhite", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockwhitetwostepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockwhitetwostepstairsZMinus() : base("clayblockwhite", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockwhitetwostepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockwhitetwostepstairsZPlus() : base("clayblockwhite", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz+");
        }
    }
}