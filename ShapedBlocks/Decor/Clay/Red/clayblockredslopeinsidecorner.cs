using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockredslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockredslopeinsidecornerRecipe() : base("clayblockredslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockredslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockredslopeinsidecorner : DecorativeType
    {
        public clayblockredslopeinsidecorner() : base("clayblockred", "slopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockredslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockred";
        }
    }

    [NCAPIType]
    public class clayblockredslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockredslopeinsidecornerXMinus() : base("clayblockred", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockredslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockredslopeinsidecornerXPlus() : base("clayblockred", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockredslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockredslopeinsidecornerZMinus() : base("clayblockred", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockredslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockredslopeinsidecornerZPlus() : base("clayblockred", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz+");
        }
    }
}