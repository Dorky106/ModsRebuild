using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpurpleupsidedownslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockpurpleupsidedownslopeinsidecornerRecipe() : base("clayblockpurpleupsidedownslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpurpleupsidedownslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedownslopeinsidecorner : DecorativeType
    {
        public clayblockpurpleupsidedownslopeinsidecorner() : base("clayblockpurple", "upsidedownslopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpurpleupsidedownslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockpurple";
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockpurpleupsidedownslopeinsidecornerXMinus() : base("clayblockpurple", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockpurpleupsidedownslopeinsidecornerXPlus() : base("clayblockpurple", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockpurpleupsidedownslopeinsidecornerZMinus() : base("clayblockpurple", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockpurpleupsidedownslopeinsidecornerZPlus() : base("clayblockpurple", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz+");
        }
    }
}