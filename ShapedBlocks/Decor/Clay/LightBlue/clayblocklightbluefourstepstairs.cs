using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklightbluefourstepstairsRecipe : BaseRecipe
    {
        public clayblocklightbluefourstepstairsRecipe() : base("clayblocklightbluefourstepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklightbluefourstepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblocklightbluefourstepstairs : DecorativeType
    {
        public clayblocklightbluefourstepstairs() : base("clayblocklightblue", "fourstepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklightbluefourstepstairs.png"))
        {
            this.SideAll = "clayblocklightblue";
        }
    }

    [NCAPIType]
    public class clayblocklightbluefourstepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblocklightbluefourstepstairsXMinus() : base("clayblocklightblue", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblocklightbluefourstepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblocklightbluefourstepstairsXPlus() : base("clayblocklightblue", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblocklightbluefourstepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblocklightbluefourstepstairsZMinus() : base("clayblocklightblue", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblocklightbluefourstepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblocklightbluefourstepstairsZPlus() : base("clayblocklightblue", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}