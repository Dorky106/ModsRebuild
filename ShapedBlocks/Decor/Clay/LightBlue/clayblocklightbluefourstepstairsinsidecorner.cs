using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklightbluefourstepstairsinsidecornerRecipe : BaseRecipe
    {
        public clayblocklightbluefourstepstairsinsidecornerRecipe() : base("clayblocklightbluefourstepstairsinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklightbluefourstepstairsinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocklightbluefourstepstairsinsidecorner : DecorativeType
    {
        public clayblocklightbluefourstepstairsinsidecorner() : base("clayblocklightblue", "fourstepstairsinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklightbluefourstepstairsinsidecorner.png"))
        {
            this.SideAll = "clayblocklightblue";
        }
    }

    [NCAPIType]
    public class clayblocklightbluefourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblocklightbluefourstepstairsinsidecornerXMinus() : base("clayblocklightblue", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblocklightbluefourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblocklightbluefourstepstairsinsidecornerXPlus() : base("clayblocklightblue", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblocklightbluefourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblocklightbluefourstepstairsinsidecornerZMinus() : base("clayblocklightblue", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblocklightbluefourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblocklightbluefourstepstairsinsidecornerZPlus() : base("clayblocklightblue", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz+");
        }
    }
}