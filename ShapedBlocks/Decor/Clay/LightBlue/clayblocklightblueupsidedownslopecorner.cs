using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklightblueupsidedownslopecornerRecipe : BaseRecipe
    {
        public clayblocklightblueupsidedownslopecornerRecipe() : base("clayblocklightblueupsidedownslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklightblueupsidedownslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedownslopecorner : DecorativeType
    {
        public clayblocklightblueupsidedownslopecorner() : base("clayblocklightblue", "upsidedownslopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklightblueupsidedownslopecorner.png"))
        {
            this.SideAll = "clayblocklightblue";
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedownslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblocklightblueupsidedownslopecornerXMinus() : base("clayblocklightblue", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedownslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblocklightblueupsidedownslopecornerXPlus() : base("clayblocklightblue", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedownslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblocklightblueupsidedownslopecornerZMinus() : base("clayblocklightblue", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedownslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblocklightblueupsidedownslopecornerZPlus() : base("clayblocklightblue", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz+");
        }
    }
}