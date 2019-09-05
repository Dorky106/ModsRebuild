using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpinkslopeRecipe : BaseRecipe
    {
        public clayblockpinkslopeRecipe() : base("clayblockpinksloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpinkslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockpinkslope : DecorativeType
    {
        public clayblockpinkslope() : base("clayblockpink", "slope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpinkslope.png"))
        {
            this.SideAll = "clayblockpink";
        }
    }

    [NCAPIType]
    public class clayblockpinkslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockpinkslopeXMinus() : base("clayblockpink", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex-");
        }
    }

    [NCAPIType]
    public class clayblockpinkslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockpinkslopeXPlus() : base("clayblockpink", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex+");
        }
    }

    [NCAPIType]
    public class clayblockpinkslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockpinkslopeZMinus() : base("clayblockpink", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez-");
        }
    }

    [NCAPIType]
    public class clayblockpinkslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockpinkslopeZPlus() : base("clayblockpink", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez+");
        }
    }
}