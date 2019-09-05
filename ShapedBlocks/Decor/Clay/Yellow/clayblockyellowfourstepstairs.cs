using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockyellowfourstepstairsRecipe : BaseRecipe
    {
        public clayblockyellowfourstepstairsRecipe() : base("clayblockyellowfourstepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockyellowfourstepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockyellowfourstepstairs : DecorativeType
    {
        public clayblockyellowfourstepstairs() : base("clayblockyellow", "fourstepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockyellowfourstepstairs.png"))
        {
            this.SideAll = "clayblockyellow";
        }
    }

    [NCAPIType]
    public class clayblockyellowfourstepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockyellowfourstepstairsXMinus() : base("clayblockyellow", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockyellowfourstepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockyellowfourstepstairsXPlus() : base("clayblockyellow", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockyellowfourstepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockyellowfourstepstairsZMinus() : base("clayblockyellow", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockyellowfourstepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockyellowfourstepstairsZPlus() : base("clayblockyellow", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}