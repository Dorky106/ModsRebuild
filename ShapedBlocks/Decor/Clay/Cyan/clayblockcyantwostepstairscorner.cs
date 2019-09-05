using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockcyantwostepstairscornerRecipe : BaseRecipe
    {
        public clayblockcyantwostepstairscornerRecipe() : base("clayblockcyantwostepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockcyantwostepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockcyantwostepstairscorner : DecorativeType
    {
        public clayblockcyantwostepstairscorner() : base("clayblockcyan", "twostepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockcyantwostepstairscorner.png"))
        {
            this.SideAll = "clayblockcyan";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockcyantwostepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockcyantwostepstairscornerXMinus() : base("clayblockcyan", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockcyantwostepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockcyantwostepstairscornerXPlus() : base("clayblockcyan", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockcyantwostepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockcyantwostepstairscornerZMinus() : base("clayblockcyan", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockcyantwostepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockcyantwostepstairscornerZPlus() : base("clayblockcyan", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz+");
        }
    }
}