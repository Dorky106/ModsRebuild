using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockupsidedownslopecornerRecipe : BaseRecipe
    {
        public clayblockupsidedownslopecornerRecipe() : base("clayblockupsidedownslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockupsidedownslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockupsidedownslopecorner : DecorativeType
    {
        public clayblockupsidedownslopecorner() : base("clayblock", "upsidedownslopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockupsidedownslopecorner.png"))
        {
            this.SideAll = "clayblock";
        }
    }

    [NCAPIType]
    public class clayblockupsidedownslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockupsidedownslopecornerXMinus() : base("clayblock", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockupsidedownslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockupsidedownslopecornerXPlus() : base("clayblock", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockupsidedownslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockupsidedownslopecornerZMinus() : base("clayblock", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockupsidedownslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockupsidedownslopecornerZPlus() : base("clayblock", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz+");
        }
    }
}