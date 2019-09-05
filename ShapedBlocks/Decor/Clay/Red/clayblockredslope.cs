using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockredslopeRecipe : BaseRecipe
    {
        public clayblockredslopeRecipe() : base("clayblockredsloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockredslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockredslope : DecorativeType
    {
        public clayblockredslope() : base("clayblockred", "slope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockredslope.png"))
        {
            this.SideAll = "clayblockred";
        }
    }

    [NCAPIType]
    public class clayblockredslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockredslopeXMinus() : base("clayblockred", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex-");
        }
    }

    [NCAPIType]
    public class clayblockredslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockredslopeXPlus() : base("clayblockred", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex+");
        }
    }

    [NCAPIType]
    public class clayblockredslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockredslopeZMinus() : base("clayblockred", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez-");
        }
    }

    [NCAPIType]
    public class clayblockredslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockredslopeZPlus() : base("clayblockred", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez+");
        }
    }
}