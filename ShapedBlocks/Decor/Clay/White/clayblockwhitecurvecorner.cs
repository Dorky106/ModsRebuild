using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockwhitecurvecornerRecipe : BaseRecipe
    {
        public clayblockwhitecurvecornerRecipe() : base("clayblockwhitecurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockwhitecurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockwhitecurvecorner : DecorativeType
    {
        public clayblockwhitecurvecorner() : base("clayblockwhite", "curvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockwhitecurvecorner.png"))
        {
            this.SideAll = "clayblockwhite";
        }
    }

    [NCAPIType]
    public class clayblockwhitecurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockwhitecurvecornerXMinus() : base("clayblockwhite", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockwhitecurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockwhitecurvecornerXPlus() : base("clayblockwhite", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockwhitecurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockwhitecurvecornerZMinus() : base("clayblockwhite", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockwhitecurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockwhitecurvecornerZPlus() : base("clayblockwhite", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz+");
        }
    }
}