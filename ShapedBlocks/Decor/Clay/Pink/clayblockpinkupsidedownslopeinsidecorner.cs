using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpinkupsidedownslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockpinkupsidedownslopeinsidecornerRecipe() : base("clayblockpinkupsidedownslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpinkupsidedownslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedownslopeinsidecorner : DecorativeType
    {
        public clayblockpinkupsidedownslopeinsidecorner() : base("clayblockpink", "upsidedownslopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpinkupsidedownslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockpink";
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockpinkupsidedownslopeinsidecornerXMinus() : base("clayblockpink", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockpinkupsidedownslopeinsidecornerXPlus() : base("clayblockpink", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockpinkupsidedownslopeinsidecornerZMinus() : base("clayblockpink", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockpinkupsidedownslopeinsidecornerZPlus() : base("clayblockpink", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz+");
        }
    }
}