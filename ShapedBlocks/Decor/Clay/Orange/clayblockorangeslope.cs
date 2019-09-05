using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockorangeslopeRecipe : BaseRecipe
    {
        public clayblockorangeslopeRecipe() : base("clayblockorangesloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockorangeslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockorangeslope : DecorativeType
    {
        public clayblockorangeslope() : base("clayblockorange", "slope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockorangeslope.png"))
        {
            this.SideAll = "clayblockorange";
        }
    }

    [NCAPIType]
    public class clayblockorangeslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockorangeslopeXMinus() : base("clayblockorange", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex-");
        }
    }

    [NCAPIType]
    public class clayblockorangeslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockorangeslopeXPlus() : base("clayblockorange", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex+");
        }
    }

    [NCAPIType]
    public class clayblockorangeslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockorangeslopeZMinus() : base("clayblockorange", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez-");
        }
    }

    [NCAPIType]
    public class clayblockorangeslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockorangeslopeZPlus() : base("clayblockorange", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez+");
        }
    }
}