using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockorangeupsidedownslopeRecipe : BaseRecipe
    {
        public clayblockorangeupsidedownslopeRecipe() : base("clayblockorangeupsidedownsloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockorangeupsidedownslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedownslope : DecorativeType
    {
        public clayblockorangeupsidedownslope() : base("clayblockorange", "upsidedownslope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockorangeupsidedownslope.png"))
        {
            this.SideAll = "clayblockorange";
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedownslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockorangeupsidedownslopeXMinus() : base("clayblockorange", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex-");
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedownslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockorangeupsidedownslopeXPlus() : base("clayblockorange", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex+");
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedownslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockorangeupsidedownslopeZMinus() : base("clayblockorange", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez-");
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedownslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockorangeupsidedownslopeZPlus() : base("clayblockorange", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez+");
        }
    }
}