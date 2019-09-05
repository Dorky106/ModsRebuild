using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class ClayblockwhiteslopeinsidecornerRecipe : BaseRecipe
    {
        public ClayblockwhiteslopeinsidecornerRecipe() : base("clayblockwhiteslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockwhiteslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class Clayblockwhiteslopeinsidecorner : DecorativeType
    {
        public Clayblockwhiteslopeinsidecorner() : base("clayblockwhite", "slopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockwhiteslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockwhite";
        }
    }

    [NCAPIType]
    public class clayblockwhiteslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockwhiteslopeinsidecornerXMinus() : base("clayblockwhite", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockwhiteslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockwhiteslopeinsidecornerXPlus() : base("clayblockwhite", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockwhiteslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockwhiteslopeinsidecornerZMinus() : base("clayblockwhite", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockwhiteslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockwhiteslopeinsidecornerZPlus() : base("clayblockwhite", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz+");
        }
    }
}