using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockslopecornerRecipe : BaseRecipe
    {
        public clayblockslopecornerRecipe() : base("clayblockslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockslopecorner : DecorativeType
    {
        public clayblockslopecorner() : base("clayblock", "slopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockslopecorner.png"))
        {
            this.SideAll = "clayblock";
        }
    }

    [NCAPIType]
    public class clayblockslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockslopecornerXMinus() : base("clayblock", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockslopecornerXPlus() : base("clayblock", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockslopecornerZMinus() : base("clayblock", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockslopecornerZPlus() : base("clayblock", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz+");
        }
    }
}