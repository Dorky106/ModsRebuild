using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblackcurvecornerRecipe : BaseRecipe
    {
        public clayblockblackcurvecornerRecipe() : base("clayblockblackcurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblackcurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockblackcurvecorner : DecorativeType
    {
        public clayblockblackcurvecorner() : base("clayblockblack", "curvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblackcurvecorner.png"))
        {
            this.SideAll = "clayblockblack";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblackcurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockblackcurvecornerXMinus() : base("clayblockblack", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockblackcurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockblackcurvecornerXPlus() : base("clayblockblack", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockblackcurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockblackcurvecornerZMinus() : base("clayblockblack", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockblackcurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockblackcurvecornerZPlus() : base("clayblockblack", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz+");
        }
    }
}