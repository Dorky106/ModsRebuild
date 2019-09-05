using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockorangetwostepstairsRecipe : BaseRecipe
    {
        public clayblockorangetwostepstairsRecipe() : base("clayblockorangetwostepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockorangetwostepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockorangetwostepstairs : DecorativeType
    {
        public clayblockorangetwostepstairs() : base("clayblockorange", "twostepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockorangetwostepstairs.png"))
        {
            this.SideAll = "clayblockorange";
        }
    }

    [NCAPIType]
    public class clayblockorangetwostepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockorangetwostepstairsXMinus() : base("clayblockorange", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockorangetwostepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockorangetwostepstairsXPlus() : base("clayblockorange", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockorangetwostepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockorangetwostepstairsZMinus() : base("clayblockorange", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockorangetwostepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockorangetwostepstairsZPlus() : base("clayblockorange", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz+");
        }
    }
}