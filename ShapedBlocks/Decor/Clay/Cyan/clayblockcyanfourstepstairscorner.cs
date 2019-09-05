using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockcyanfourstepstairscornerRecipe : BaseRecipe
    {
        public clayblockcyanfourstepstairscornerRecipe() : base("clayblockcyanfourstepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockcyanfourstepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockcyanfourstepstairscorner : DecorativeType
    {
        public clayblockcyanfourstepstairscorner() : base("clayblockcyan", "fourstepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockcyanfourstepstairscorner.png"))
        {
            this.SideAll = "clayblockcyan";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockcyanfourstepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockcyanfourstepstairscornerXMinus() : base("clayblockcyan", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockcyanfourstepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockcyanfourstepstairscornerXPlus() : base("clayblockcyan", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockcyanfourstepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockcyanfourstepstairscornerZMinus() : base("clayblockcyan", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockcyanfourstepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockcyanfourstepstairscornerZPlus() : base("clayblockcyan", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz+");
        }
    }
}