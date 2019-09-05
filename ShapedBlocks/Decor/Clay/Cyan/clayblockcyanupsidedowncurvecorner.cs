using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockcyanupsidedowncurvecornerRecipe : BaseRecipe
    {
        public clayblockcyanupsidedowncurvecornerRecipe() : base("clayblockcyanupsidedowncurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockcyanupsidedowncurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedowncurvecorner : DecorativeType
    {
        public clayblockcyanupsidedowncurvecorner() : base("clayblockcyan", "upsidedowncurvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockcyanupsidedowncurvecorner.png"))
        {
            this.SideAll = "clayblockcyan";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedowncurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockcyanupsidedowncurvecornerXMinus() : base("clayblockcyan", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedowncurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockcyanupsidedowncurvecornerXPlus() : base("clayblockcyan", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedowncurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockcyanupsidedowncurvecornerZMinus() : base("clayblockcyan", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockcyanupsidedowncurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockcyanupsidedowncurvecornerZPlus() : base("clayblockcyan", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz+");
        }
    }
}