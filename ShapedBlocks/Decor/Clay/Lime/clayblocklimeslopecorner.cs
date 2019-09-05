using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklimeslopecornerRecipe : BaseRecipe
    {
        public clayblocklimeslopecornerRecipe() : base("clayblocklimeslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklimeslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocklimeslopecorner : DecorativeType
    {
        public clayblocklimeslopecorner() : base("clayblocklime", "slopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklimeslopecorner.png"))
        {
            this.SideAll = "clayblocklime";
        }
    }

    [NCAPIType]
    public class clayblocklimeslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblocklimeslopecornerXMinus() : base("clayblocklime", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblocklimeslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblocklimeslopecornerXPlus() : base("clayblocklime", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblocklimeslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblocklimeslopecornerZMinus() : base("clayblocklime", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblocklimeslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblocklimeslopecornerZPlus() : base("clayblocklime", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz+");
        }
    }
}