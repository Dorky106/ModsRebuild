using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockwhiteupsidedownslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockwhiteupsidedownslopeinsidecornerRecipe() : base("clayblockwhiteupsidedownslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockwhiteupsidedownslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedownslopeinsidecorner : DecorativeType
    {
        public clayblockwhiteupsidedownslopeinsidecorner() : base("clayblockwhite", "upsidedownslopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockwhiteupsidedownslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockwhite";
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockwhiteupsidedownslopeinsidecornerXMinus() : base("clayblockwhite", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockwhiteupsidedownslopeinsidecornerXPlus() : base("clayblockwhite", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockwhiteupsidedownslopeinsidecornerZMinus() : base("clayblockwhite", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockwhiteupsidedownslopeinsidecornerZPlus() : base("clayblockwhite", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz+");
        }
    }
}