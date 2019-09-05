using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpinkslopecornerRecipe : BaseRecipe
    {
        public clayblockpinkslopecornerRecipe() : base("clayblockpinkslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpinkslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockpinkslopecorner : DecorativeType
    {
        public clayblockpinkslopecorner() : base("clayblockpink", "slopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpinkslopecorner.png"))
        {
            this.SideAll = "clayblockpink";
        }
    }

    [NCAPIType]
    public class clayblockpinkslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockpinkslopecornerXMinus() : base("clayblockpink", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockpinkslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockpinkslopecornerXPlus() : base("clayblockpink", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockpinkslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockpinkslopecornerZMinus() : base("clayblockpink", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockpinkslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockpinkslopecornerZPlus() : base("clayblockpink", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz+");
        }
    }
}