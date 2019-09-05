using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockcyancurvecornerRecipe : BaseRecipe
    {
        public clayblockcyancurvecornerRecipe() : base("clayblockcyancurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockcyancurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockcyancurvecorner : DecorativeType
    {
        public clayblockcyancurvecorner() : base("clayblockcyan", "curvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockcyancurvecorner.png"))
        {
            this.SideAll = "clayblockcyan";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockcyancurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockcyancurvecornerXMinus() : base("clayblockcyan", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockcyancurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockcyancurvecornerXPlus() : base("clayblockcyan", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockcyancurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockcyancurvecornerZMinus() : base("clayblockcyan", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockcyancurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockcyancurvecornerZPlus() : base("clayblockcyan", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz+");
        }
    }
}