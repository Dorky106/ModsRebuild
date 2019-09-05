using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpurpleslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockpurpleslopeinsidecornerRecipe() : base("clayblockpurpleslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpurpleslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockpurpleslopeinsidecorner : DecorativeType
    {
        public clayblockpurpleslopeinsidecorner() : base("clayblockpurple", "slopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpurpleslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockpurple";
        }
    }

    [NCAPIType]
    public class clayblockpurpleslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockpurpleslopeinsidecornerXMinus() : base("clayblockpurple", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockpurpleslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockpurpleslopeinsidecornerXPlus() : base("clayblockpurple", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockpurpleslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockpurpleslopeinsidecornerZMinus() : base("clayblockpurple", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockpurpleslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockpurpleslopeinsidecornerZPlus() : base("clayblockpurple", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz+");
        }
    }
}