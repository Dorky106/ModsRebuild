using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockyellowcurvecornerRecipe : BaseRecipe
    {
        public clayblockyellowcurvecornerRecipe() : base("clayblockyellowcurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockyellowcurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockyellowcurvecorner : DecorativeType
    {
        public clayblockyellowcurvecorner() : base("clayblockyellow", "curvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockyellowcurvecorner.png"))
        {
            this.SideAll = "clayblockyellow";
        }
    }

    [NCAPIType]
    public class clayblockyellowcurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockyellowcurvecornerXMinus() : base("clayblockyellow", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockyellowcurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockyellowcurvecornerXPlus() : base("clayblockyellow", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockyellowcurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockyellowcurvecornerZMinus() : base("clayblockyellow", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockyellowcurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockyellowcurvecornerZPlus() : base("clayblockyellow", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz+");
        }
    }
}