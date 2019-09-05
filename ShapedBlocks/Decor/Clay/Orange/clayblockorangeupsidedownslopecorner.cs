using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockorangeupsidedownslopecornerRecipe : BaseRecipe
    {
        public clayblockorangeupsidedownslopecornerRecipe() : base("clayblockorangeupsidedownslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockorangeupsidedownslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedownslopecorner : DecorativeType
    {
        public clayblockorangeupsidedownslopecorner() : base("clayblockorange", "upsidedownslopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockorangeupsidedownslopecorner.png"))
        {
            this.SideAll = "clayblockorange";
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedownslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockorangeupsidedownslopecornerXMinus() : base("clayblockorange", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedownslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockorangeupsidedownslopecornerXPlus() : base("clayblockorange", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedownslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockorangeupsidedownslopecornerZMinus() : base("clayblockorange", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedownslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockorangeupsidedownslopecornerZPlus() : base("clayblockorange", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz+");
        }
    }
}