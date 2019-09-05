using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockredupsidedownslopeRecipe : BaseRecipe
    {
        public clayblockredupsidedownslopeRecipe() : base("clayblockredupsidedownsloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockredupsidedownslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockredupsidedownslope : DecorativeType
    {
        public clayblockredupsidedownslope() : base("clayblockred", "upsidedownslope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockredupsidedownslope.png"))
        {
            this.SideAll = "clayblockred";
        }
    }

    [NCAPIType]
    public class clayblockredupsidedownslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockredupsidedownslopeXMinus() : base("clayblockred", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex-");
        }
    }

    [NCAPIType]
    public class clayblockredupsidedownslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockredupsidedownslopeXPlus() : base("clayblockred", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex+");
        }
    }

    [NCAPIType]
    public class clayblockredupsidedownslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockredupsidedownslopeZMinus() : base("clayblockred", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez-");
        }
    }

    [NCAPIType]
    public class clayblockredupsidedownslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockredupsidedownslopeZPlus() : base("clayblockred", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez+");
        }
    }
}