using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class ClayblockyellowupsidedownslopeRecipe : BaseRecipe
    {
        public ClayblockyellowupsidedownslopeRecipe() : base("clayblockyellowupsidedownsloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockyellowupsidedownslope", 1));
        }
    }

    [NCAPIType]
    public class Clayblockyellowupsidedownslope : DecorativeType
    {
        public Clayblockyellowupsidedownslope() : base("clayblockyellow", "upsidedownslope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockyellowupsidedownslope.png"))
        {
            this.SideAll = "clayblockyellow";
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedownslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockyellowupsidedownslopeXMinus() : base("clayblockyellow", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex-");
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedownslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockyellowupsidedownslopeXPlus() : base("clayblockyellow", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex+");
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedownslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockyellowupsidedownslopeZMinus() : base("clayblockyellow", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez-");
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedownslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockyellowupsidedownslopeZPlus() : base("clayblockyellow", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez+");
        }
    }
}