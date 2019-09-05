using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockyellowslopeRecipe : BaseRecipe
    {
        public clayblockyellowslopeRecipe() : base("clayblockyellowsloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockyellowslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockyellowslope : DecorativeType
    {
        public clayblockyellowslope() : base("clayblockyellow", "slope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockyellowslope.png"))
        {
            this.SideAll = "clayblockyellow";
        }
    }

    [NCAPIType]
    public class clayblockyellowslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockyellowslopeXMinus() : base("clayblockyellow", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex-");
        }
    }

    [NCAPIType]
    public class clayblockyellowslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockyellowslopeXPlus() : base("clayblockyellow", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex+");
        }
    }

    [NCAPIType]
    public class clayblockyellowslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockyellowslopeZMinus() : base("clayblockyellow", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez-");
        }
    }

    [NCAPIType]
    public class clayblockyellowslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockyellowslopeZPlus() : base("clayblockyellow", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez+");
        }
    }
}