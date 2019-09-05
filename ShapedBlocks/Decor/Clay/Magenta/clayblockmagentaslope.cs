using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockmagentaslopeRecipe : BaseRecipe
    {
        public clayblockmagentaslopeRecipe() : base("clayblockmagentasloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockmagentaslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockmagentaslope : DecorativeType
    {
        public clayblockmagentaslope() : base("clayblockmagenta", "slope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockmagentaslope.png"))
        {
            this.SideAll = "clayblockmagenta";
        }
    }

    [NCAPIType]
    public class clayblockmagentaslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockmagentaslopeXMinus() : base("clayblockmagenta", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex-");
        }
    }

    [NCAPIType]
    public class clayblockmagentaslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockmagentaslopeXPlus() : base("clayblockmagenta", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex+");
        }
    }

    [NCAPIType]
    public class clayblockmagentaslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockmagentaslopeZMinus() : base("clayblockmagenta", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez-");
        }
    }

    [NCAPIType]
    public class clayblockmagentaslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockmagentaslopeZPlus() : base("clayblockmagenta", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez+");
        }
    }
}