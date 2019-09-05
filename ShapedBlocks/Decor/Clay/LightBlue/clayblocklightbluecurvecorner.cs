using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklightbluecurvecornerRecipe : BaseRecipe
    {
        public clayblocklightbluecurvecornerRecipe() : base("clayblocklightbluecurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklightbluecurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocklightbluecurvecorner : DecorativeType
    {
        public clayblocklightbluecurvecorner() : base("clayblocklightblue", "curvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklightbluecurvecorner.png"))
        {
            this.SideAll = "clayblocklightblue";
        }
    }

    [NCAPIType]
    public class clayblocklightbluecurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblocklightbluecurvecornerXMinus() : base("clayblocklightblue", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblocklightbluecurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblocklightbluecurvecornerXPlus() : base("clayblocklightblue", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblocklightbluecurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblocklightbluecurvecornerZMinus() : base("clayblocklightblue", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblocklightbluecurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblocklightbluecurvecornerZPlus() : base("clayblocklightblue", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz+");
        }
    }
}