using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblackupsidedownslopecornerRecipe : BaseRecipe
    {
        public clayblockblackupsidedownslopecornerRecipe() : base("clayblockblackupsidedownslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblackupsidedownslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedownslopecorner : DecorativeType
    {
        public clayblockblackupsidedownslopecorner() : base("clayblockblack", "upsidedownslopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblackupsidedownslopecorner.png"))
        {
            this.SideAll = "clayblockblack";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedownslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockblackupsidedownslopecornerXMinus() : base("clayblockblack", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedownslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockblackupsidedownslopecornerXPlus() : base("clayblockblack", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedownslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockblackupsidedownslopecornerZMinus() : base("clayblockblack", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedownslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockblackupsidedownslopecornerZPlus() : base("clayblockblack", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz+");
        }
    }
}