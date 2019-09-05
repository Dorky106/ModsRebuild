using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklimeslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblocklimeslopeinsidecornerRecipe() : base("clayblocklimeslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklimeslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocklimeslopeinsidecorner : DecorativeType
    {
        public clayblocklimeslopeinsidecorner() : base("clayblocklime", "slopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklimeslopeinsidecorner.png"))
        {
            this.SideAll = "clayblocklime";
        }
    }

    [NCAPIType]
    public class clayblocklimeslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblocklimeslopeinsidecornerXMinus() : base("clayblocklime", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblocklimeslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblocklimeslopeinsidecornerXPlus() : base("clayblocklime", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblocklimeslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblocklimeslopeinsidecornerZMinus() : base("clayblocklime", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblocklimeslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblocklimeslopeinsidecornerZPlus() : base("clayblocklime", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz+");
        }
    }
}