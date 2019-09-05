using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockslopeRecipe : BaseRecipe
    {
        public clayblockslopeRecipe() : base("clayblocksloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockslope : DecorativeType
    {
        public clayblockslope() : base("clayblock", "slope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockslope.png"))
        {
            this.SideAll = "clayblock";
        }
    }

    [NCAPIType]
    public class clayblockslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockslopeXMinus() : base("clayblock", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex-");
        }
    }

    [NCAPIType]
    public class clayblockslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockslopeXPlus() : base("clayblock", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex+");
        }
    }

    [NCAPIType]
    public class clayblockslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockslopeZMinus() : base("clayblock", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez-");
        }
    }

    [NCAPIType]
    public class clayblockslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockslopeZPlus() : base("clayblock", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez+");
        }
    }
}