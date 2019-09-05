using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblackslopecornerRecipe : BaseRecipe
    {
        public clayblockblackslopecornerRecipe() : base("clayblockblackslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblackslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockblackslopecorner : DecorativeType
    {
        public clayblockblackslopecorner() : base("clayblockblack", "slopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblackslopecorner.png"))
        {
            this.SideAll = "clayblockblack";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblackslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockblackslopecornerXMinus() : base("clayblockblack", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockblackslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockblackslopecornerXPlus() : base("clayblockblack", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockblackslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockblackslopecornerZMinus() : base("clayblockblack", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockblackslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockblackslopecornerZPlus() : base("clayblockblack", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz+");
        }
    }
}