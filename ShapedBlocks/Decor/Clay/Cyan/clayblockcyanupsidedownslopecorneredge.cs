using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockcyanupsidedownslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockcyanupsidedownslopecorneredgeRecipe() : base("clayblockcyanupsidedownslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockcyanupsidedownslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedownslopecorneredge : DecorativeType
    {
        public clayblockcyanupsidedownslopecorneredge() : base("clayblockcyan", "upsidedownslopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockcyanupsidedownslopecorneredge.png"))
        {
            this.SideAll = "clayblockcyan";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockcyanupsidedownslopecorneredgeXMinus() : base("clayblockcyan", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockcyanupsidedownslopecorneredgeXPlus() : base("clayblockcyan", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockcyanupsidedownslopecorneredgeZMinus() : base("clayblockcyan", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockcyanupsidedownslopecorneredgeZPlus() : base("clayblockcyan", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez+");
        }
    }
}