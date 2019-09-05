using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockorangefourstepstairsRecipe : BaseRecipe
    {
        public clayblockorangefourstepstairsRecipe() : base("clayblockorangefourstepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockorangefourstepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockorangefourstepstairs : DecorativeType
    {
        public clayblockorangefourstepstairs() : base("clayblockorange", "fourstepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockorangefourstepstairs.png"))
        {
            this.SideAll = "clayblockorange";
        }
    }

    [NCAPIType]
    public class clayblockorangefourstepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockorangefourstepstairsXMinus() : base("clayblockorange", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockorangefourstepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockorangefourstepstairsXPlus() : base("clayblockorange", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockorangefourstepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockorangefourstepstairsZMinus() : base("clayblockorange", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockorangefourstepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockorangefourstepstairsZPlus() : base("clayblockorange", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}