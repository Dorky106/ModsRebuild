using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklightblueupsidedownslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblocklightblueupsidedownslopeinsidecornerRecipe() : base("clayblocklightblueupsidedownslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklightblueupsidedownslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedownslopeinsidecorner : DecorativeType
    {
        public clayblocklightblueupsidedownslopeinsidecorner() : base("clayblocklightblue", "upsidedownslopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklightblueupsidedownslopeinsidecorner.png"))
        {
            this.SideAll = "clayblocklightblue";
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblocklightblueupsidedownslopeinsidecornerXMinus() : base("clayblocklightblue", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblocklightblueupsidedownslopeinsidecornerXPlus() : base("clayblocklightblue", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblocklightblueupsidedownslopeinsidecornerZMinus() : base("clayblocklightblue", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblocklightblueupsidedownslopeinsidecornerZPlus() : base("clayblocklightblue", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz+");
        }
    }
}