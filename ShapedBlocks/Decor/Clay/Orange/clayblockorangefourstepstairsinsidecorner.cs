using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockorangefourstepstairsinsidecornerRecipe : BaseRecipe
    {
        public clayblockorangefourstepstairsinsidecornerRecipe() : base("clayblockorangefourstepstairsinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockorangefourstepstairsinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockorangefourstepstairsinsidecorner : DecorativeType
    {
        public clayblockorangefourstepstairsinsidecorner() : base("clayblockorange", "fourstepstairsinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockorangefourstepstairsinsidecorner.png"))
        {
            this.SideAll = "clayblockorange";
        }
    }

    [NCAPIType]
    public class clayblockorangefourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockorangefourstepstairsinsidecornerXMinus() : base("clayblockorange", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockorangefourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockorangefourstepstairsinsidecornerXPlus() : base("clayblockorange", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockorangefourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockorangefourstepstairsinsidecornerZMinus() : base("clayblockorange", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockorangefourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockorangefourstepstairsinsidecornerZPlus() : base("clayblockorange", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz+");
        }
    }
}