using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpinkupsidedownslopecornerRecipe : BaseRecipe
    {
        public clayblockpinkupsidedownslopecornerRecipe() : base("clayblockpinkupsidedownslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpinkupsidedownslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedownslopecorner : DecorativeType
    {
        public clayblockpinkupsidedownslopecorner() : base("clayblockpink", "upsidedownslopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpinkupsidedownslopecorner.png"))
        {
            this.SideAll = "clayblockpink";
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedownslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockpinkupsidedownslopecornerXMinus() : base("clayblockpink", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedownslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockpinkupsidedownslopecornerXPlus() : base("clayblockpink", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedownslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockpinkupsidedownslopecornerZMinus() : base("clayblockpink", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedownslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockpinkupsidedownslopecornerZPlus() : base("clayblockpink", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz+");
        }
    }
}