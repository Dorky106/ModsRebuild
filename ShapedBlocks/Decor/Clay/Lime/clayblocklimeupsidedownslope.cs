using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklimeupsidedownslopeRecipe : BaseRecipe
    {
        public clayblocklimeupsidedownslopeRecipe() : base("clayblocklimeupsidedownsloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklimeupsidedownslope", 1));
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedownslope : DecorativeType
    {
        public clayblocklimeupsidedownslope() : base("clayblocklime", "upsidedownslope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklimeupsidedownslope.png"))
        {
            this.SideAll = "clayblocklime";
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedownslopeXMinus : DecorativeTypeXMinus
    {
        public clayblocklimeupsidedownslopeXMinus() : base("clayblocklime", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex-");
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedownslopeXPlus : DecorativeTypeXPlus
    {
        public clayblocklimeupsidedownslopeXPlus() : base("clayblocklime", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex+");
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedownslopeZMinus : DecorativeTypeZMinus
    {
        public clayblocklimeupsidedownslopeZMinus() : base("clayblocklime", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez-");
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedownslopeZPlus : DecorativeTypeZPlus
    {
        public clayblocklimeupsidedownslopeZPlus() : base("clayblocklime", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez+");
        }
    }
}