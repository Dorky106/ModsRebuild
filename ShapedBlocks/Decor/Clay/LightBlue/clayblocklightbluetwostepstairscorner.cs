using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklightbluetwostepstairscornerRecipe : BaseRecipe
    {
        public clayblocklightbluetwostepstairscornerRecipe() : base("clayblocklightbluetwostepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklightbluetwostepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocklightbluetwostepstairscorner : DecorativeType
    {
        public clayblocklightbluetwostepstairscorner() : base("clayblocklightblue", "twostepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklightbluetwostepstairscorner.png"))
        {
            this.SideAll = "clayblocklightblue";
        }
    }

    [NCAPIType]
    public class clayblocklightbluetwostepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblocklightbluetwostepstairscornerXMinus() : base("clayblocklightblue", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblocklightbluetwostepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblocklightbluetwostepstairscornerXPlus() : base("clayblocklightblue", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblocklightbluetwostepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblocklightbluetwostepstairscornerZMinus() : base("clayblocklightblue", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblocklightbluetwostepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblocklightbluetwostepstairscornerZPlus() : base("clayblocklightblue", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz+");
        }
    }
}