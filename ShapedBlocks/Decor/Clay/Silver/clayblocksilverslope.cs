using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocksilverslopeRecipe : BaseRecipe
    {
        public clayblocksilverslopeRecipe() : base("clayblocksilversloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocksilverslope", 1));
        }
    }

    [NCAPIType]
    public class clayblocksilverslope : DecorativeType
    {
        public clayblocksilverslope() : base("clayblocksilver", "slope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocksilverslope.png"))
        {
            this.SideAll = "clayblocksilver";
        }
    }

    [NCAPIType]
    public class clayblocksilverslopeXMinus : DecorativeTypeXMinus
    {
        public clayblocksilverslopeXMinus() : base("clayblocksilver", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex-");
        }
    }

    [NCAPIType]
    public class clayblocksilverslopeXPlus : DecorativeTypeXPlus
    {
        public clayblocksilverslopeXPlus() : base("clayblocksilver", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex+");
        }
    }

    [NCAPIType]
    public class clayblocksilverslopeZMinus : DecorativeTypeZMinus
    {
        public clayblocksilverslopeZMinus() : base("clayblocksilver", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez-");
        }
    }

    [NCAPIType]
    public class clayblocksilverslopeZPlus : DecorativeTypeZPlus
    {
        public clayblocksilverslopeZPlus() : base("clayblocksilver", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez+");
        }
    }
}