using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgreenupsidedownslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockgreenupsidedownslopeinsidecornerRecipe() : base("clayblockgreenupsidedownslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgreenupsidedownslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedownslopeinsidecorner : DecorativeType
    {
        public clayblockgreenupsidedownslopeinsidecorner() : base("clayblockgreen", "upsidedownslopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgreenupsidedownslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockgreen";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockgreenupsidedownslopeinsidecornerXMinus() : base("clayblockgreen", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockgreenupsidedownslopeinsidecornerXPlus() : base("clayblockgreen", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockgreenupsidedownslopeinsidecornerZMinus() : base("clayblockgreen", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockgreenupsidedownslopeinsidecornerZPlus() : base("clayblockgreen", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz+");
        }
    }
}