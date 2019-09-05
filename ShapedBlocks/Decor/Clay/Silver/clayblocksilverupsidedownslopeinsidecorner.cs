using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocksilverupsidedownslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblocksilverupsidedownslopeinsidecornerRecipe() : base("clayblocksilverupsidedownslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocksilverupsidedownslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedownslopeinsidecorner : DecorativeType
    {
        public clayblocksilverupsidedownslopeinsidecorner() : base("clayblocksilver", "upsidedownslopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocksilverupsidedownslopeinsidecorner.png"))
        {
            this.SideAll = "clayblocksilver";
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblocksilverupsidedownslopeinsidecornerXMinus() : base("clayblocksilver", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblocksilverupsidedownslopeinsidecornerXPlus() : base("clayblocksilver", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblocksilverupsidedownslopeinsidecornerZMinus() : base("clayblocksilver", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblocksilverupsidedownslopeinsidecornerZPlus() : base("clayblocksilver", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz+");
        }
    }
}