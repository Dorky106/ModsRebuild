using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockredcurvecornerRecipe : BaseRecipe
    {
        public clayblockredcurvecornerRecipe() : base("clayblockredcurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockredcurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockredcurvecorner : DecorativeType
    {
        public clayblockredcurvecorner() : base("clayblockred", "curvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockredcurvecorner.png"))
        {
            this.SideAll = "clayblockred";
        }
    }

    [NCAPIType]
    public class clayblockredcurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockredcurvecornerXMinus() : base("clayblockred", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockredcurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockredcurvecornerXPlus() : base("clayblockred", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockredcurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockredcurvecornerZMinus() : base("clayblockred", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockredcurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockredcurvecornerZPlus() : base("clayblockred", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz+");
        }
    }
}