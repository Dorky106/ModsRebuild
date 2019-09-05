using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocktwostepstairsRecipe : BaseRecipe
    {
        public clayblocktwostepstairsRecipe() : base("clayblocktwostepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocktwostepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblocktwostepstairs : DecorativeType
    {
        public clayblocktwostepstairs() : base("clayblock", "twostepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocktwostepstairs.png"))
        {
            this.SideAll = "clayblock";
        }
    }

    [NCAPIType]
    public class clayblocktwostepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblocktwostepstairsXMinus() : base("clayblock", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblocktwostepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblocktwostepstairsXPlus() : base("clayblock", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblocktwostepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblocktwostepstairsZMinus() : base("clayblock", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblocktwostepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblocktwostepstairsZPlus() : base("clayblock", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz+");
        }
    }
}