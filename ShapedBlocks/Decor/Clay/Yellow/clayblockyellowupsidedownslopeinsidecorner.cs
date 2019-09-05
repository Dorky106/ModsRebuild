using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockyellowupsidedownslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockyellowupsidedownslopeinsidecornerRecipe() : base("clayblockyellowupsidedownslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockyellowupsidedownslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedownslopeinsidecorner : DecorativeType
    {
        public clayblockyellowupsidedownslopeinsidecorner() : base("clayblockyellow", "upsidedownslopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockyellowupsidedownslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockyellow";
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockyellowupsidedownslopeinsidecornerXMinus() : base("clayblockyellow", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockyellowupsidedownslopeinsidecornerXPlus() : base("clayblockyellow", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockyellowupsidedownslopeinsidecornerZMinus() : base("clayblockyellow", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockyellowupsidedownslopeinsidecornerZPlus() : base("clayblockyellow", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz+");
        }
    }
}