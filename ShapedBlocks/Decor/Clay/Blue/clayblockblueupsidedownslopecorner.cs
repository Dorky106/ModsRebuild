using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblueupsidedownslopecornerRecipe : BaseRecipe
    {
        public clayblockblueupsidedownslopecornerRecipe() : base("clayblockblueupsidedownslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblueupsidedownslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedownslopecorner : DecorativeType
    {
        public clayblockblueupsidedownslopecorner() : base("clayblockblue", "upsidedownslopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblueupsidedownslopecorner.png"))
        {
            this.SideAll = "clayblockblue";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedownslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockblueupsidedownslopecornerXMinus() : base("clayblockblue", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedownslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockblueupsidedownslopecornerXPlus() : base("clayblockblue", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedownslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockblueupsidedownslopecornerZMinus() : base("clayblockblue", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedownslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockblueupsidedownslopecornerZPlus() : base("clayblockblue", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz+");
        }
    }
}