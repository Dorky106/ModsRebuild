using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockyellowtwostepstairsRecipe : BaseRecipe
    {
        public clayblockyellowtwostepstairsRecipe() : base("clayblockyellowtwostepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockyellowtwostepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockyellowtwostepstairs : DecorativeType
    {
        public clayblockyellowtwostepstairs() : base("clayblockyellow", "twostepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockyellowtwostepstairs.png"))
        {
            this.SideAll = "clayblockyellow";
        }
    }

    [NCAPIType]
    public class clayblockyellowtwostepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockyellowtwostepstairsXMinus() : base("clayblockyellow", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockyellowtwostepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockyellowtwostepstairsXPlus() : base("clayblockyellow", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockyellowtwostepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockyellowtwostepstairsZMinus() : base("clayblockyellow", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockyellowtwostepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockyellowtwostepstairsZPlus() : base("clayblockyellow", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz+");
        }
    }
}