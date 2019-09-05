using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklimetwostepstairsRecipe : BaseRecipe
    {
        public clayblocklimetwostepstairsRecipe() : base("clayblocklimetwostepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklimetwostepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblocklimetwostepstairs : DecorativeType
    {
        public clayblocklimetwostepstairs() : base("clayblocklime", "twostepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklimetwostepstairs.png"))
        {
            this.SideAll = "clayblocklime";
        }
    }

    [NCAPIType]
    public class clayblocklimetwostepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblocklimetwostepstairsXMinus() : base("clayblocklime", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblocklimetwostepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblocklimetwostepstairsXPlus() : base("clayblocklime", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblocklimetwostepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblocklimetwostepstairsZMinus() : base("clayblocklime", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblocklimetwostepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblocklimetwostepstairsZPlus() : base("clayblocklime", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz+");
        }
    }
}