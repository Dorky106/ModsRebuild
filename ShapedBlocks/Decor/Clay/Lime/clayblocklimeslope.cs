using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklimeslopeRecipe : BaseRecipe
    {
        public clayblocklimeslopeRecipe() : base("clayblocklimesloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklimeslope", 1));
        }
    }

    [NCAPIType]
    public class clayblocklimeslope : DecorativeType
    {
        public clayblocklimeslope() : base("clayblocklime", "slope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklimeslope.png"))
        {
            this.SideAll = "clayblocklime";
        }
    }

    [NCAPIType]
    public class clayblocklimeslopeXMinus : DecorativeTypeXMinus
    {
        public clayblocklimeslopeXMinus() : base("clayblocklime", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex-");
        }
    }

    [NCAPIType]
    public class clayblocklimeslopeXPlus : DecorativeTypeXPlus
    {
        public clayblocklimeslopeXPlus() : base("clayblocklime", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex+");
        }
    }

    [NCAPIType]
    public class clayblocklimeslopeZMinus : DecorativeTypeZMinus
    {
        public clayblocklimeslopeZMinus() : base("clayblocklime", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez-");
        }
    }

    [NCAPIType]
    public class clayblocklimeslopeZPlus : DecorativeTypeZPlus
    {
        public clayblocklimeslopeZPlus() : base("clayblocklime", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez+");
        }
    }
}