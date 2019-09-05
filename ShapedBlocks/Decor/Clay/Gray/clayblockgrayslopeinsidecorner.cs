using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgrayslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockgrayslopeinsidecornerRecipe() : base("clayblockgrayslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgrayslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockgrayslopeinsidecorner : DecorativeType
    {
        public clayblockgrayslopeinsidecorner() : base("clayblockgray", "slopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgrayslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockgray";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgrayslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockgrayslopeinsidecornerXMinus() : base("clayblockgray", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockgrayslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockgrayslopeinsidecornerXPlus() : base("clayblockgray", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockgrayslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockgrayslopeinsidecornerZMinus() : base("clayblockgray", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockgrayslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockgrayslopeinsidecornerZPlus() : base("clayblockgray", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz+");
        }
    }
}