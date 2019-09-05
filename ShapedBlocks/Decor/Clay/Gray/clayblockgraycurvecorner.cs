using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgraycurvecornerRecipe : BaseRecipe
    {
        public clayblockgraycurvecornerRecipe() : base("clayblockgraycurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgraycurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockgraycurvecorner : DecorativeType
    {
        public clayblockgraycurvecorner() : base("clayblockgray", "curvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgraycurvecorner.png"))
        {
            this.SideAll = "clayblockgray";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgraycurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockgraycurvecornerXMinus() : base("clayblockgray", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockgraycurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockgraycurvecornerXPlus() : base("clayblockgray", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockgraycurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockgraycurvecornerZMinus() : base("clayblockgray", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockgraycurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockgraycurvecornerZPlus() : base("clayblockgray", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz+");
        }
    }
}