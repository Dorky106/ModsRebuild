using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbrownslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockbrownslopeinsidecornerRecipe() : base("clayblockbrownslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbrownslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockbrownslopeinsidecorner : DecorativeType
    {
        public clayblockbrownslopeinsidecorner() : base("clayblockbrown", "slopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbrownslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockbrown";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbrownslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockbrownslopeinsidecornerXMinus() : base("clayblockbrown", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockbrownslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockbrownslopeinsidecornerXPlus() : base("clayblockbrown", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockbrownslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockbrownslopeinsidecornerZMinus() : base("clayblockbrown", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockbrownslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockbrownslopeinsidecornerZPlus() : base("clayblockbrown", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz+");
        }
    }
}