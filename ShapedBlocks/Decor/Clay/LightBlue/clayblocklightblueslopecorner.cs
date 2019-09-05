using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklightblueslopecornerRecipe : BaseRecipe
    {
        public clayblocklightblueslopecornerRecipe() : base("clayblocklightblueslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklightblueslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocklightblueslopecorner : DecorativeType
    {
        public clayblocklightblueslopecorner() : base("clayblocklightblue", "slopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklightblueslopecorner.png"))
        {
            this.SideAll = "clayblocklightblue";
        }
    }

    [NCAPIType]
    public class clayblocklightblueslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblocklightblueslopecornerXMinus() : base("clayblocklightblue", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblocklightblueslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblocklightblueslopecornerXPlus() : base("clayblocklightblue", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblocklightblueslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblocklightblueslopecornerZMinus() : base("clayblocklightblue", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblocklightblueslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblocklightblueslopecornerZPlus() : base("clayblocklightblue", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz+");
        }
    }
}