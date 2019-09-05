using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockmagentaslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockmagentaslopeinsidecornerRecipe() : base("clayblockmagentaslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockmagentaslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockmagentaslopeinsidecorner : DecorativeType
    {
        public clayblockmagentaslopeinsidecorner() : base("clayblockmagenta", "slopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockmagentaslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockmagenta";
        }
    }

    [NCAPIType]
    public class clayblockmagentaslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockmagentaslopeinsidecornerXMinus() : base("clayblockmagenta", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockmagentaslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockmagentaslopeinsidecornerXPlus() : base("clayblockmagenta", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockmagentaslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockmagentaslopeinsidecornerZMinus() : base("clayblockmagenta", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockmagentaslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockmagentaslopeinsidecornerZPlus() : base("clayblockmagenta", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz+");
        }
    }
}