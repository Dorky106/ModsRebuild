using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbrowncurvecornerRecipe : BaseRecipe
    {
        public clayblockbrowncurvecornerRecipe() : base("clayblockbrowncurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbrowncurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockbrowncurvecorner : DecorativeType
    {
        public clayblockbrowncurvecorner() : base("clayblockbrown", "curvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbrowncurvecorner.png"))
        {
            this.SideAll = "clayblockbrown";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbrowncurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockbrowncurvecornerXMinus() : base("clayblockbrown", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockbrowncurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockbrowncurvecornerXPlus() : base("clayblockbrown", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockbrowncurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockbrowncurvecornerZMinus() : base("clayblockbrown", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockbrowncurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockbrowncurvecornerZPlus() : base("clayblockbrown", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz+");
        }
    }
}