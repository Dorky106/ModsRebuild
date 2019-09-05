using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklimefourstepstairsinsidecornerRecipe : BaseRecipe
    {
        public clayblocklimefourstepstairsinsidecornerRecipe() : base("clayblocklimefourstepstairsinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklimefourstepstairsinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocklimefourstepstairsinsidecorner : DecorativeType
    {
        public clayblocklimefourstepstairsinsidecorner() : base("clayblocklime", "fourstepstairsinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklimefourstepstairsinsidecorner.png"))
        {
            this.SideAll = "clayblocklime";
        }
    }

    [NCAPIType]
    public class clayblocklimefourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblocklimefourstepstairsinsidecornerXMinus() : base("clayblocklime", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblocklimefourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblocklimefourstepstairsinsidecornerXPlus() : base("clayblocklime", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblocklimefourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblocklimefourstepstairsinsidecornerZMinus() : base("clayblocklime", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblocklimefourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblocklimefourstepstairsinsidecornerZPlus() : base("clayblocklime", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz+");
        }
    }
}