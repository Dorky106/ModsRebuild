using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockmagentacurvecornerRecipe : BaseRecipe
    {
        public clayblockmagentacurvecornerRecipe() : base("clayblockmagentacurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockmagentacurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockmagentacurvecorner : DecorativeType
    {
        public clayblockmagentacurvecorner() : base("clayblockmagenta", "curvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockmagentacurvecorner.png"))
        {
            this.SideAll = "clayblockmagenta";
        }
    }

    [NCAPIType]
    public class clayblockmagentacurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockmagentacurvecornerXMinus() : base("clayblockmagenta", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockmagentacurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockmagentacurvecornerXPlus() : base("clayblockmagenta", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockmagentacurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockmagentacurvecornerZMinus() : base("clayblockmagenta", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockmagentacurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockmagentacurvecornerZPlus() : base("clayblockmagenta", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz+");
        }
    }
}