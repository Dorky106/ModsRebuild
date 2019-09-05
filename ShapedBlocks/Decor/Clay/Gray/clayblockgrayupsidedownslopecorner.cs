using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgrayupsidedownslopecornerRecipe : BaseRecipe
    {
        public clayblockgrayupsidedownslopecornerRecipe() : base("clayblockgrayupsidedownslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgrayupsidedownslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedownslopecorner : DecorativeType
    {
        public clayblockgrayupsidedownslopecorner() : base("clayblockgray", "upsidedownslopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgrayupsidedownslopecorner.png"))
        {
            this.SideAll = "clayblockgray";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedownslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockgrayupsidedownslopecornerXMinus() : base("clayblockgray", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedownslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockgrayupsidedownslopecornerXPlus() : base("clayblockgray", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedownslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockgrayupsidedownslopecornerZMinus() : base("clayblockgray", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedownslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockgrayupsidedownslopecornerZPlus() : base("clayblockgray", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz+");
        }
    }
}