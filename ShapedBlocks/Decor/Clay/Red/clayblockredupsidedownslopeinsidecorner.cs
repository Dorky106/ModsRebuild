using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockredupsidedownslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockredupsidedownslopeinsidecornerRecipe() : base("clayblockredupsidedownslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockredupsidedownslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockredupsidedownslopeinsidecorner : DecorativeType
    {
        public clayblockredupsidedownslopeinsidecorner() : base("clayblockred", "upsidedownslopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockredupsidedownslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockred";
        }
    }

    [NCAPIType]
    public class clayblockredupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockredupsidedownslopeinsidecornerXMinus() : base("clayblockred", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockredupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockredupsidedownslopeinsidecornerXPlus() : base("clayblockred", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockredupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockredupsidedownslopeinsidecornerZMinus() : base("clayblockred", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockredupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockredupsidedownslopeinsidecornerZPlus() : base("clayblockred", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz+");
        }
    }
}