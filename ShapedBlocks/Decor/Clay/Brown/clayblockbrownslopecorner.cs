using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbrownslopecornerRecipe : BaseRecipe
    {
        public clayblockbrownslopecornerRecipe() : base("clayblockbrownslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbrownslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockbrownslopecorner : DecorativeType
    {
        public clayblockbrownslopecorner() : base("clayblockbrown", "slopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbrownslopecorner.png"))
        {
            this.SideAll = "clayblockbrown";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbrownslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockbrownslopecornerXMinus() : base("clayblockbrown", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockbrownslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockbrownslopecornerXPlus() : base("clayblockbrown", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockbrownslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockbrownslopecornerZMinus() : base("clayblockbrown", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockbrownslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockbrownslopecornerZPlus() : base("clayblockbrown", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz+");
        }
    }
}