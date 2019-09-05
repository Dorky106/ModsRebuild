using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpurplecurvecornerRecipe : BaseRecipe
    {
        public clayblockpurplecurvecornerRecipe() : base("clayblockpurplecurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpurplecurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockpurplecurvecorner : DecorativeType
    {
        public clayblockpurplecurvecorner() : base("clayblockpurple", "curvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpurplecurvecorner.png"))
        {
            this.SideAll = "clayblockpurple";
        }
    }

    [NCAPIType]
    public class clayblockpurplecurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockpurplecurvecornerXMinus() : base("clayblockpurple", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockpurplecurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockpurplecurvecornerXPlus() : base("clayblockpurple", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockpurplecurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockpurplecurvecornerZMinus() : base("clayblockpurple", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockpurplecurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockpurplecurvecornerZPlus() : base("clayblockpurple", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz+");
        }
    }
}