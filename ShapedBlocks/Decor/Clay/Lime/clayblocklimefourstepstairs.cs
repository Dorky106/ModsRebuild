using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklimefourstepstairsRecipe : BaseRecipe
    {
        public clayblocklimefourstepstairsRecipe() : base("clayblocklimefourstepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklimefourstepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblocklimefourstepstairs : DecorativeType
    {
        public clayblocklimefourstepstairs() : base("clayblocklime", "fourstepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklimefourstepstairs.png"))
        {
            this.SideAll = "clayblocklime";
        }
    }

    [NCAPIType]
    public class clayblocklimefourstepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblocklimefourstepstairsXMinus() : base("clayblocklime", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblocklimefourstepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblocklimefourstepstairsXPlus() : base("clayblocklime", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblocklimefourstepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblocklimefourstepstairsZMinus() : base("clayblocklime", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblocklimefourstepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblocklimefourstepstairsZPlus() : base("clayblocklime", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}