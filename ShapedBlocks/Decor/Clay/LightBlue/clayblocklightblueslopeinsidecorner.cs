using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklightblueslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblocklightblueslopeinsidecornerRecipe() : base("clayblocklightblueslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklightblueslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocklightblueslopeinsidecorner : DecorativeType
    {
        public clayblocklightblueslopeinsidecorner() : base("clayblocklightblue", "slopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklightblueslopeinsidecorner.png"))
        {
            this.SideAll = "clayblocklightblue";
        }
    }

    [NCAPIType]
    public class clayblocklightblueslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblocklightblueslopeinsidecornerXMinus() : base("clayblocklightblue", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblocklightblueslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblocklightblueslopeinsidecornerXPlus() : base("clayblocklightblue", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblocklightblueslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblocklightblueslopeinsidecornerZMinus() : base("clayblocklightblue", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblocklightblueslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblocklightblueslopeinsidecornerZPlus() : base("clayblocklightblue", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz+");
        }
    }
}