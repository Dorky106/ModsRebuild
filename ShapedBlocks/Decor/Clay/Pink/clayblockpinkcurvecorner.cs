using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpinkcurvecornerRecipe : BaseRecipe
    {
        public clayblockpinkcurvecornerRecipe() : base("clayblockpinkcurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpinkcurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockpinkcurvecorner : DecorativeType
    {
        public clayblockpinkcurvecorner() : base("clayblockpink", "curvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpinkcurvecorner.png"))
        {
            this.SideAll = "clayblockpink";
        }
    }

    [NCAPIType]
    public class clayblockpinkcurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockpinkcurvecornerXMinus() : base("clayblockpink", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockpinkcurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockpinkcurvecornerXPlus() : base("clayblockpink", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockpinkcurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockpinkcurvecornerZMinus() : base("clayblockpink", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockpinkcurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockpinkcurvecornerZPlus() : base("clayblockpink", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz+");
        }
    }
}