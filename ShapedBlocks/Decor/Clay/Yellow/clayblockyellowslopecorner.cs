using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class ClayblockyellowslopecornerRecipe : BaseRecipe
    {
        public ClayblockyellowslopecornerRecipe() : base("clayblockyellowslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockyellowslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockyellowslopecorner : DecorativeType
    {
        public clayblockyellowslopecorner() : base("clayblockyellow", "slopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockyellowslopecorner.png"))
        {
            this.SideAll = "clayblockyellow";
        }
    }

    [NCAPIType]
    public class clayblockyellowslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockyellowslopecornerXMinus() : base("clayblockyellow", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockyellowslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockyellowslopecornerXPlus() : base("clayblockyellow", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockyellowslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockyellowslopecornerZMinus() : base("clayblockyellow", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockyellowslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockyellowslopecornerZPlus() : base("clayblockyellow", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz+");
        }
    }
}