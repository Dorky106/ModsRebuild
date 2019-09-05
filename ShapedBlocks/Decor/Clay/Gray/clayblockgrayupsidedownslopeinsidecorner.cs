using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgrayupsidedownslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockgrayupsidedownslopeinsidecornerRecipe() : base("clayblockgrayupsidedownslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgrayupsidedownslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedownslopeinsidecorner : DecorativeType
    {
        public clayblockgrayupsidedownslopeinsidecorner() : base("clayblockgray", "upsidedownslopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgrayupsidedownslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockgray";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockgrayupsidedownslopeinsidecornerXMinus() : base("clayblockgray", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockgrayupsidedownslopeinsidecornerXPlus() : base("clayblockgray", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockgrayupsidedownslopeinsidecornerZMinus() : base("clayblockgray", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockgrayupsidedownslopeinsidecornerZPlus() : base("clayblockgray", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz+");
        }
    }
}