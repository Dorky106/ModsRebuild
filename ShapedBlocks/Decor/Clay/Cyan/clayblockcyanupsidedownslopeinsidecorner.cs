using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockcyanupsidedownslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockcyanupsidedownslopeinsidecornerRecipe() : base("clayblockcyanupsidedownslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockcyanupsidedownslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedownslopeinsidecorner : DecorativeType
    {
        public clayblockcyanupsidedownslopeinsidecorner() : base("clayblockcyan", "upsidedownslopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockcyanupsidedownslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockcyan";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockcyanupsidedownslopeinsidecornerXMinus() : base("clayblockcyan", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockcyanupsidedownslopeinsidecornerXPlus() : base("clayblockcyan", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockcyanupsidedownslopeinsidecornerZMinus() : base("clayblockcyan", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockcyanupsidedownslopeinsidecornerZPlus() : base("clayblockcyan", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz+");
        }
    }
}