using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockcyanupsidedownslopeRecipe : BaseRecipe
    {
        public clayblockcyanupsidedownslopeRecipe() : base("clayblockcyanupsidedownsloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockcyanupsidedownslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedownslope : DecorativeType
    {
        public clayblockcyanupsidedownslope() : base("clayblockcyan", "upsidedownslope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockcyanupsidedownslope.png"))
        {
            this.SideAll = "clayblockcyan";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedownslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockcyanupsidedownslopeXMinus() : base("clayblockcyan", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex-");
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedownslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockcyanupsidedownslopeXPlus() : base("clayblockcyan", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex+");
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedownslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockcyanupsidedownslopeZMinus() : base("clayblockcyan", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez-");
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedownslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockcyanupsidedownslopeZPlus() : base("clayblockcyan", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez+");
        }
    }
}