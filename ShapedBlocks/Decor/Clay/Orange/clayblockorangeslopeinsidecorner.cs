using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockorangeslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockorangeslopeinsidecornerRecipe() : base("clayblockorangeslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockorangeslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockorangeslopeinsidecorner : DecorativeType
    {
        public clayblockorangeslopeinsidecorner() : base("clayblockorange", "slopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockorangeslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockorange";
        }
    }

    [NCAPIType]
    public class clayblockorangeslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockorangeslopeinsidecornerXMinus() : base("clayblockorange", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockorangeslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockorangeslopeinsidecornerXPlus() : base("clayblockorange", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockorangeslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockorangeslopeinsidecornerZMinus() : base("clayblockorange", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockorangeslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockorangeslopeinsidecornerZPlus() : base("clayblockorange", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz+");
        }
    }
}