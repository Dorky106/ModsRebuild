using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockmagentaslopecornerRecipe : BaseRecipe
    {
        public clayblockmagentaslopecornerRecipe() : base("clayblockmagentaslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockmagentaslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockmagentaslopecorner : DecorativeType
    {
        public clayblockmagentaslopecorner() : base("clayblockmagenta", "slopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockmagentaslopecorner.png"))
        {
            this.SideAll = "clayblockmagenta";
        }
    }

    [NCAPIType]
    public class clayblockmagentaslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockmagentaslopecornerXMinus() : base("clayblockmagenta", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockmagentaslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockmagentaslopecornerXPlus() : base("clayblockmagenta", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockmagentaslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockmagentaslopecornerZMinus() : base("clayblockmagenta", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockmagentaslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockmagentaslopecornerZPlus() : base("clayblockmagenta", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz+");
        }
    }
}