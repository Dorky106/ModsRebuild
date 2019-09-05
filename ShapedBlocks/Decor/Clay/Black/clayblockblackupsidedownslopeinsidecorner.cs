using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblackupsidedownslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockblackupsidedownslopeinsidecornerRecipe() : base("clayblockblackupsidedownslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblackupsidedownslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedownslopeinsidecorner : DecorativeType
    {
        public clayblockblackupsidedownslopeinsidecorner() : base("clayblockblack", "upsidedownslopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblackupsidedownslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockblack";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockblackupsidedownslopeinsidecornerXMinus() : base("clayblockblack", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockblackupsidedownslopeinsidecornerXPlus() : base("clayblockblack", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockblackupsidedownslopeinsidecornerZMinus() : base("clayblockblack", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockblackupsidedownslopeinsidecornerZPlus() : base("clayblockblack", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz+");
        }
    }
}