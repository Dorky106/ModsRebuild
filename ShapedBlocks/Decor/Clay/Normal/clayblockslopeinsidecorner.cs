using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockslopeinsidecornerRecipe() : base("clayblockslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockslopeinsidecorner : DecorativeType
    {
        public clayblockslopeinsidecorner() : base("clayblock", "slopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockslopeinsidecorner.png"))
        {
            this.SideAll = "clayblock";
        }
    }

    [NCAPIType]
    public class clayblockslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockslopeinsidecornerXMinus() : base("clayblock", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockslopeinsidecornerXPlus() : base("clayblock", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockslopeinsidecornerZMinus() : base("clayblock", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockslopeinsidecornerZPlus() : base("clayblock", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz+");
        }
    }
}