using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockwhiteslopecornerRecipe : BaseRecipe
    {
        public clayblockwhiteslopecornerRecipe() : base("clayblockwhiteslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockwhiteslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockwhiteslopecorner : DecorativeType
    {
        public clayblockwhiteslopecorner() : base("clayblockwhite", "slopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockwhiteslopecorner.png"))
        {
            this.SideAll = "clayblockwhite";
        }
    }

    [NCAPIType]
    public class clayblockwhiteslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockwhiteslopecornerXMinus() : base("clayblockwhite", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockwhiteslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockwhiteslopecornerXPlus() : base("clayblockwhite", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockwhiteslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockwhiteslopecornerZMinus() : base("clayblockwhite", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockwhiteslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockwhiteslopecornerZPlus() : base("clayblockwhite", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz+");
        }
    }
}