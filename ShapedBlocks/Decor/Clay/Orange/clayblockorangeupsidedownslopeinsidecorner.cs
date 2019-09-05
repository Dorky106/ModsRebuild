using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockorangeupsidedownslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockorangeupsidedownslopeinsidecornerRecipe() : base("clayblockorangeupsidedownslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockorangeupsidedownslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedownslopeinsidecorner : DecorativeType
    {
        public clayblockorangeupsidedownslopeinsidecorner() : base("clayblockorange", "upsidedownslopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockorangeupsidedownslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockorange";
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockorangeupsidedownslopeinsidecornerXMinus() : base("clayblockorange", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockorangeupsidedownslopeinsidecornerXPlus() : base("clayblockorange", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockorangeupsidedownslopeinsidecornerZMinus() : base("clayblockorange", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockorangeupsidedownslopeinsidecornerZPlus() : base("clayblockorange", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz+");
        }
    }
}