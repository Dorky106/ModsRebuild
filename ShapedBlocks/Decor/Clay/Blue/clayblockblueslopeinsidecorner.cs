using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblueslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockblueslopeinsidecornerRecipe() : base("clayblockblueslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblueslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockblueslopeinsidecorner : DecorativeType
    {
        public clayblockblueslopeinsidecorner() : base("clayblockblue", "slopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblueslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockblue";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblueslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockblueslopeinsidecornerXMinus() : base("clayblockblue", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockblueslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockblueslopeinsidecornerXPlus() : base("clayblockblue", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockblueslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockblueslopeinsidecornerZMinus() : base("clayblockblue", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockblueslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockblueslopeinsidecornerZPlus() : base("clayblockblue", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz+");
        }
    }
}