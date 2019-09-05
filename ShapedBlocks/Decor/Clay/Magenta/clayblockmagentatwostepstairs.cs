using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockmagentatwostepstairsRecipe : BaseRecipe
    {
        public clayblockmagentatwostepstairsRecipe() : base("clayblockmagentatwostepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockmagentatwostepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockmagentatwostepstairs : DecorativeType
    {
        public clayblockmagentatwostepstairs() : base("clayblockmagenta", "twostepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockmagentatwostepstairs.png"))
        {
            this.SideAll = "clayblockmagenta";
        }
    }

    [NCAPIType]
    public class clayblockmagentatwostepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockmagentatwostepstairsXMinus() : base("clayblockmagenta", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockmagentatwostepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockmagentatwostepstairsXPlus() : base("clayblockmagenta", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockmagentatwostepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockmagentatwostepstairsZMinus() : base("clayblockmagenta", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockmagentatwostepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockmagentatwostepstairsZPlus() : base("clayblockmagenta", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz+");
        }
    }
}