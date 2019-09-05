using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockwhiteupsidedownslopecornerRecipe : BaseRecipe
    {
        public clayblockwhiteupsidedownslopecornerRecipe() : base("clayblockwhiteupsidedownslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockwhiteupsidedownslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedownslopecorner : DecorativeType
    {
        public clayblockwhiteupsidedownslopecorner() : base("clayblockwhite", "upsidedownslopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockwhiteupsidedownslopecorner.png"))
        {
            this.SideAll = "clayblockwhite";
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedownslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockwhiteupsidedownslopecornerXMinus() : base("clayblockwhite", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedownslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockwhiteupsidedownslopecornerXPlus() : base("clayblockwhite", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedownslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockwhiteupsidedownslopecornerZMinus() : base("clayblockwhite", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedownslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockwhiteupsidedownslopecornerZPlus() : base("clayblockwhite", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz+");
        }
    }
}