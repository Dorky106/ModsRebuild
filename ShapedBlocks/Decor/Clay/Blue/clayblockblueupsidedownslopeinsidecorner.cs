using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblueupsidedownslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockblueupsidedownslopeinsidecornerRecipe() : base("clayblockblueupsidedownslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblueupsidedownslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedownslopeinsidecorner : DecorativeType
    {
        public clayblockblueupsidedownslopeinsidecorner() : base("clayblockblue", "upsidedownslopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblueupsidedownslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockblue";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockblueupsidedownslopeinsidecornerXMinus() : base("clayblockblue", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockblueupsidedownslopeinsidecornerXPlus() : base("clayblockblue", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockblueupsidedownslopeinsidecornerZMinus() : base("clayblockblue", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockblueupsidedownslopeinsidecornerZPlus() : base("clayblockblue", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz+");
        }
    }
}