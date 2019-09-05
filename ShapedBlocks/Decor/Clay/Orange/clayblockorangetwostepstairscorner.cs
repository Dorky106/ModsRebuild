using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class ClayblockorangetwostepstairscornerRecipe : BaseRecipe
    {
        public ClayblockorangetwostepstairscornerRecipe() : base("clayblockorangetwostepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockorangetwostepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockorangetwostepstairscorner : DecorativeType
    {
        public clayblockorangetwostepstairscorner() : base("clayblockorange", "twostepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockorangetwostepstairscorner.png"))
        {
            this.SideAll = "clayblockorange";
        }
    }

    [NCAPIType]
    public class clayblockorangetwostepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockorangetwostepstairscornerXMinus() : base("clayblockorange", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockorangetwostepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockorangetwostepstairscornerXPlus() : base("clayblockorange", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockorangetwostepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockorangetwostepstairscornerZMinus() : base("clayblockorange", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockorangetwostepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockorangetwostepstairscornerZPlus() : base("clayblockorange", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz+");
        }
    }
}