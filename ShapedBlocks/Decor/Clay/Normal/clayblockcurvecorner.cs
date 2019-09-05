using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockcurvecornerRecipe : BaseRecipe
    {
        public clayblockcurvecornerRecipe() : base("clayblockcurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockcurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockcurvecorner : DecorativeType
    {
        public clayblockcurvecorner() : base("clayblock", "curvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockcurvecorner.png"))
        {
            this.SideAll = "clayblock";
        }
    }

    [NCAPIType]
    public class clayblockcurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockcurvecornerXMinus() : base("clayblock", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockcurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockcurvecornerXPlus() : base("clayblock", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockcurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockcurvecornerZMinus() : base("clayblock", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockcurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockcurvecornerZPlus() : base("clayblock", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz+");
        }
    }
}