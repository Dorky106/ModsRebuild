using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockupsidedownslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockupsidedownslopeinsidecornerRecipe() : base("clayblockupsidedownslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockupsidedownslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockupsidedownslopeinsidecorner : DecorativeType
    {
        public clayblockupsidedownslopeinsidecorner() : base("clayblock", "upsidedownslopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockupsidedownslopeinsidecorner.png"))
        {
            this.SideAll = "clayblock";
        }
    }

    [NCAPIType]
    public class clayblockupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockupsidedownslopeinsidecornerXMinus() : base("clayblock", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockupsidedownslopeinsidecornerXPlus() : base("clayblock", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockupsidedownslopeinsidecornerZMinus() : base("clayblock", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockupsidedownslopeinsidecornerZPlus() : base("clayblock", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz+");
        }
    }
}