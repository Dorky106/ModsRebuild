using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockcyanupsidedownslopecornerRecipe : BaseRecipe
    {
        public clayblockcyanupsidedownslopecornerRecipe() : base("clayblockcyanupsidedownslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockcyanupsidedownslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedownslopecorner : DecorativeType
    {
        public clayblockcyanupsidedownslopecorner() : base("clayblockcyan", "upsidedownslopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockcyanupsidedownslopecorner.png"))
        {
            this.SideAll = "clayblockcyan";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedownslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockcyanupsidedownslopecornerXMinus() : base("clayblockcyan", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedownslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockcyanupsidedownslopecornerXPlus() : base("clayblockcyan", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedownslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockcyanupsidedownslopecornerZMinus() : base("clayblockcyan", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedownslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockcyanupsidedownslopecornerZPlus() : base("clayblockcyan", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz+");
        }
    }
}