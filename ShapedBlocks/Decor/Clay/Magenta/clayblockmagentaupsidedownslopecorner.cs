using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockmagentaupsidedownslopecornerRecipe : BaseRecipe
    {
        public clayblockmagentaupsidedownslopecornerRecipe() : base("clayblockmagentaupsidedownslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockmagentaupsidedownslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedownslopecorner : DecorativeType
    {
        public clayblockmagentaupsidedownslopecorner() : base("clayblockmagenta", "upsidedownslopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockmagentaupsidedownslopecorner.png"))
        {
            this.SideAll = "clayblockmagenta";
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedownslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockmagentaupsidedownslopecornerXMinus() : base("clayblockmagenta", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedownslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockmagentaupsidedownslopecornerXPlus() : base("clayblockmagenta", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedownslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockmagentaupsidedownslopecornerZMinus() : base("clayblockmagenta", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedownslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockmagentaupsidedownslopecornerZPlus() : base("clayblockmagenta", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz+");
        }
    }
}