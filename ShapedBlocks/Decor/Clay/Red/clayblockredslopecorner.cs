using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockredslopecornerRecipe : BaseRecipe
    {
        public clayblockredslopecornerRecipe() : base("clayblockredslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockredslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockredslopecorner : DecorativeType
    {
        public clayblockredslopecorner() : base("clayblockred", "slopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockredslopecorner.png"))
        {
            this.SideAll = "clayblockred";
        }
    }

    [NCAPIType]
    public class clayblockredslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockredslopecornerXMinus() : base("clayblockred", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockredslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockredslopecornerXPlus() : base("clayblockred", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockredslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockredslopecornerZMinus() : base("clayblockred", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockredslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockredslopecornerZPlus() : base("clayblockred", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz+");
        }
    }
}