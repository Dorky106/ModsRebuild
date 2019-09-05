using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpurpleupsidedownslopecornerRecipe : BaseRecipe
    {
        public clayblockpurpleupsidedownslopecornerRecipe() : base("clayblockpurpleupsidedownslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpurpleupsidedownslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedownslopecorner : DecorativeType
    {
        public clayblockpurpleupsidedownslopecorner() : base("clayblockpurple", "upsidedownslopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpurpleupsidedownslopecorner.png"))
        {
            this.SideAll = "clayblockpurple";
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedownslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockpurpleupsidedownslopecornerXMinus() : base("clayblockpurple", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedownslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockpurpleupsidedownslopecornerXPlus() : base("clayblockpurple", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedownslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockpurpleupsidedownslopecornerZMinus() : base("clayblockpurple", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedownslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockpurpleupsidedownslopecornerZPlus() : base("clayblockpurple", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz+");
        }
    }
}