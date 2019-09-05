using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockredtwostepstairsRecipe : BaseRecipe
    {
        public clayblockredtwostepstairsRecipe() : base("clayblockredtwostepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockredtwostepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockredtwostepstairs : DecorativeType
    {
        public clayblockredtwostepstairs() : base("clayblockred", "twostepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockredtwostepstairs.png"))
        {
            this.SideAll = "clayblockred";
        }
    }

    [NCAPIType]
    public class clayblockredtwostepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockredtwostepstairsXMinus() : base("clayblockred", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockredtwostepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockredtwostepstairsXPlus() : base("clayblockred", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockredtwostepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockredtwostepstairsZMinus() : base("clayblockred", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockredtwostepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockredtwostepstairsZPlus() : base("clayblockred", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz+");
        }
    }
}