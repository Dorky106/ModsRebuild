using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklimecurvecornerRecipe : BaseRecipe
    {
        public clayblocklimecurvecornerRecipe() : base("clayblocklimecurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklimecurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocklimecurvecorner : DecorativeType
    {
        public clayblocklimecurvecorner() : base("clayblocklime", "curvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklimecurvecorner.png"))
        {
            this.SideAll = "clayblocklime";
        }
    }

    [NCAPIType]
    public class clayblocklimecurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblocklimecurvecornerXMinus() : base("clayblocklime", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblocklimecurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblocklimecurvecornerXPlus() : base("clayblocklime", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblocklimecurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblocklimecurvecornerZMinus() : base("clayblocklime", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblocklimecurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblocklimecurvecornerZPlus() : base("clayblocklime", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz+");
        }
    }
}