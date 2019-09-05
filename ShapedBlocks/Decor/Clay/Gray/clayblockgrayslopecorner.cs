using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgrayslopecornerRecipe : BaseRecipe
    {
        public clayblockgrayslopecornerRecipe() : base("clayblockgrayslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgrayslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockgrayslopecorner : DecorativeType
    {
        public clayblockgrayslopecorner() : base("clayblockgray", "slopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgrayslopecorner.png"))
        {
            this.SideAll = "clayblockgray";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgrayslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockgrayslopecornerXMinus() : base("clayblockgray", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockgrayslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockgrayslopecornerXPlus() : base("clayblockgray", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockgrayslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockgrayslopecornerZMinus() : base("clayblockgray", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockgrayslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockgrayslopecornerZPlus() : base("clayblockgray", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz+");
        }
    }
}