using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockmagentaupsidedownslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockmagentaupsidedownslopeinsidecornerRecipe() : base("clayblockmagentaupsidedownslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockmagentaupsidedownslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedownslopeinsidecorner : DecorativeType
    {
        public clayblockmagentaupsidedownslopeinsidecorner() : base("clayblockmagenta", "upsidedownslopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockmagentaupsidedownslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockmagenta";
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockmagentaupsidedownslopeinsidecornerXMinus() : base("clayblockmagenta", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockmagentaupsidedownslopeinsidecornerXPlus() : base("clayblockmagenta", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockmagentaupsidedownslopeinsidecornerZMinus() : base("clayblockmagenta", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockmagentaupsidedownslopeinsidecornerZPlus() : base("clayblockmagenta", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz+");
        }
    }
}