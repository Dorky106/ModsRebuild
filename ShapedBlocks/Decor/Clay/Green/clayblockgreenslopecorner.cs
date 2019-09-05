using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgreenslopecornerRecipe : BaseRecipe
    {
        public clayblockgreenslopecornerRecipe() : base("clayblockgreenslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgreenslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockgreenslopecorner : DecorativeType
    {
        public clayblockgreenslopecorner() : base("clayblockgreen", "slopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgreenslopecorner.png"))
        {
            this.SideAll = "clayblockgreen";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgreenslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockgreenslopecornerXMinus() : base("clayblockgreen", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockgreenslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockgreenslopecornerXPlus() : base("clayblockgreen", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockgreenslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockgreenslopecornerZMinus() : base("clayblockgreen", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockgreenslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockgreenslopecornerZPlus() : base("clayblockgreen", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz+");
        }
    }
}