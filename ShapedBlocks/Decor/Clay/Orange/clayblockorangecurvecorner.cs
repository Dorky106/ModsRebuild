using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockorangecurvecornerRecipe : BaseRecipe
    {
        public clayblockorangecurvecornerRecipe() : base("clayblockorangecurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockorangecurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockorangecurvecorner : DecorativeType
    {
        public clayblockorangecurvecorner() : base("clayblockorange", "curvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockorangecurvecorner.png"))
        {
            this.SideAll = "clayblockorange";
        }
    }

    [NCAPIType]
    public class clayblockorangecurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockorangecurvecornerXMinus() : base("clayblockorange", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockorangecurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockorangecurvecornerXPlus() : base("clayblockorange", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockorangecurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockorangecurvecornerZMinus() : base("clayblockorange", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockorangecurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockorangecurvecornerZPlus() : base("clayblockorange", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz+");
        }
    }
}