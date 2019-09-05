using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblueslopecornerRecipe : BaseRecipe
    {
        public clayblockblueslopecornerRecipe() : base("clayblockblueslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblueslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockblueslopecorner : DecorativeType
    {
        public clayblockblueslopecorner() : base("clayblockblue", "slopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblueslopecorner.png"))
        {
            this.SideAll = "clayblockblue";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblueslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockblueslopecornerXMinus() : base("clayblockblue", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockblueslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockblueslopecornerXPlus() : base("clayblockblue", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockblueslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockblueslopecornerZMinus() : base("clayblockblue", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockblueslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockblueslopecornerZPlus() : base("clayblockblue", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz+");
        }
    }
}