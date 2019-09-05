using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockyellowslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockyellowslopeinsidecornerRecipe() : base("clayblockyellowslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockyellowslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockyellowslopeinsidecorner : DecorativeType
    {
        public clayblockyellowslopeinsidecorner() : base("clayblockyellow", "slopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockyellowslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockyellow";
        }
    }

    [NCAPIType]
    public class clayblockyellowslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockyellowslopeinsidecornerXMinus() : base("clayblockyellow", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockyellowslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockyellowslopeinsidecornerXPlus() : base("clayblockyellow", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockyellowslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockyellowslopeinsidecornerZMinus() : base("clayblockyellow", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockyellowslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockyellowslopeinsidecornerZPlus() : base("clayblockyellow", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz+");
        }
    }
}