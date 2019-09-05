using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockorangeslopecornerRecipe : BaseRecipe
    {
        public clayblockorangeslopecornerRecipe() : base("clayblockorangeslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockorangeslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockorangeslopecorner : DecorativeType
    {
        public clayblockorangeslopecorner() : base("clayblockorange", "slopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockorangeslopecorner.png"))
        {
            this.SideAll = "clayblockorange";
        }
    }

    [NCAPIType]
    public class clayblockorangeslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockorangeslopecornerXMinus() : base("clayblockorange", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockorangeslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockorangeslopecornerXPlus() : base("clayblockorange", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockorangeslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockorangeslopecornerZMinus() : base("clayblockorange", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockorangeslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockorangeslopecornerZPlus() : base("clayblockorange", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz+");
        }
    }
}