using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbrownslopeRecipe : BaseRecipe
    {
        public clayblockbrownslopeRecipe() : base("clayblockbrownsloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbrownslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockbrownslope : DecorativeType
    {
        public clayblockbrownslope() : base("clayblockbrown", "slope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbrownslope.png"))
        {
            this.SideAll = "clayblockbrown";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbrownslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockbrownslopeXMinus() : base("clayblockbrown", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex-");
        }
    }

    [NCAPIType]
    public class clayblockbrownslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockbrownslopeXPlus() : base("clayblockbrown", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex+");
        }
    }

    [NCAPIType]
    public class clayblockbrownslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockbrownslopeZMinus() : base("clayblockbrown", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez-");
        }
    }

    [NCAPIType]
    public class clayblockbrownslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockbrownslopeZPlus() : base("clayblockbrown", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez+");
        }
    }
}