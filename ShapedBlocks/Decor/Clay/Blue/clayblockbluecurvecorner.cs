using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbluecurvecornerRecipe : BaseRecipe
    {
        public clayblockbluecurvecornerRecipe() : base("clayblockbluecurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbluecurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockbluecurvecorner : DecorativeType
    {
        public clayblockbluecurvecorner() : base("clayblockblue", "curvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbluecurvecorner.png"))
        {
            this.SideAll = "clayblockblue";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbluecurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockbluecurvecornerXMinus() : base("clayblockblue", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockbluecurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockbluecurvecornerXPlus() : base("clayblockblue", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockbluecurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockbluecurvecornerZMinus() : base("clayblockblue", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockbluecurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockbluecurvecornerZPlus() : base("clayblockblue", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz+");
        }
    }
}