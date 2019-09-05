using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpurpleslopecornerRecipe : BaseRecipe
    {
        public clayblockpurpleslopecornerRecipe() : base("clayblockpurpleslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpurpleslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockpurpleslopecorner : DecorativeType
    {
        public clayblockpurpleslopecorner() : base("clayblockpurple", "slopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpurpleslopecorner.png"))
        {
            this.SideAll = "clayblockpurple";
        }
    }

    [NCAPIType]
    public class clayblockpurpleslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockpurpleslopecornerXMinus() : base("clayblockpurple", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockpurpleslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockpurpleslopecornerXPlus() : base("clayblockpurple", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockpurpleslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockpurpleslopecornerZMinus() : base("clayblockpurple", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockpurpleslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockpurpleslopecornerZPlus() : base("clayblockpurple", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz+");
        }
    }
}