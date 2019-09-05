using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgreenslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockgreenslopeinsidecornerRecipe() : base("clayblockgreenslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgreenslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockgreenslopeinsidecorner : DecorativeType
    {
        public clayblockgreenslopeinsidecorner() : base("clayblockgreen", "slopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgreenslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockgreen";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgreenslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockgreenslopeinsidecornerXMinus() : base("clayblockgreen", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockgreenslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockgreenslopeinsidecornerXPlus() : base("clayblockgreen", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockgreenslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockgreenslopeinsidecornerZMinus() : base("clayblockgreen", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockgreenslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockgreenslopeinsidecornerZPlus() : base("clayblockgreen", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz+");
        }
    }
}