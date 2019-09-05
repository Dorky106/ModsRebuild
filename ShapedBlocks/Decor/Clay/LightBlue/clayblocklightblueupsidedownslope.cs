using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklightblueupsidedownslopeRecipe : BaseRecipe
    {
        public clayblocklightblueupsidedownslopeRecipe() : base("clayblocklightblueupsidedownsloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklightblueupsidedownslope", 1));
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedownslope : DecorativeType
    {
        public clayblocklightblueupsidedownslope() : base("clayblocklightblue", "upsidedownslope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklightblueupsidedownslope.png"))
        {
            this.SideAll = "clayblocklightblue";
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedownslopeXMinus : DecorativeTypeXMinus
    {
        public clayblocklightblueupsidedownslopeXMinus() : base("clayblocklightblue", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex-");
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedownslopeXPlus : DecorativeTypeXPlus
    {
        public clayblocklightblueupsidedownslopeXPlus() : base("clayblocklightblue", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex+");
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedownslopeZMinus : DecorativeTypeZMinus
    {
        public clayblocklightblueupsidedownslopeZMinus() : base("clayblocklightblue", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez-");
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedownslopeZPlus : DecorativeTypeZPlus
    {
        public clayblocklightblueupsidedownslopeZPlus() : base("clayblocklightblue", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez+");
        }
    }
}