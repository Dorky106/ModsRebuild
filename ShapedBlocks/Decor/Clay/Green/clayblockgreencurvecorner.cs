using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgreencurvecornerRecipe : BaseRecipe
    {
        public clayblockgreencurvecornerRecipe() : base("clayblockgreencurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgreencurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockgreencurvecorner : DecorativeType
    {
        public clayblockgreencurvecorner() : base("clayblockgreen", "curvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgreencurvecorner.png"))
        {
            this.SideAll = "clayblockgreen";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgreencurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockgreencurvecornerXMinus() : base("clayblockgreen", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockgreencurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockgreencurvecornerXPlus() : base("clayblockgreen", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockgreencurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockgreencurvecornerZMinus() : base("clayblockgreen", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockgreencurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockgreencurvecornerZPlus() : base("clayblockgreen", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz+");
        }
    }
}