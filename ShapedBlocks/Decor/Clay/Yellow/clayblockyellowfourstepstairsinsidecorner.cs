using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockyellowfourstepstairsinsidecornerRecipe : BaseRecipe
    {
        public clayblockyellowfourstepstairsinsidecornerRecipe() : base("clayblockyellowfourstepstairsinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockyellowfourstepstairsinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockyellowfourstepstairsinsidecorner : DecorativeType
    {
        public clayblockyellowfourstepstairsinsidecorner() : base("clayblockyellow", "fourstepstairsinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockyellowfourstepstairsinsidecorner.png"))
        {
            this.SideAll = "clayblockyellow";
        }
    }

    [NCAPIType]
    public class clayblockyellowfourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockyellowfourstepstairsinsidecornerXMinus() : base("clayblockyellow", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockyellowfourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockyellowfourstepstairsinsidecornerXPlus() : base("clayblockyellow", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockyellowfourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockyellowfourstepstairsinsidecornerZMinus() : base("clayblockyellow", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockyellowfourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockyellowfourstepstairsinsidecornerZPlus() : base("clayblockyellow", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz+");
        }
    }
}