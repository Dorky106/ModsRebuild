using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockcyanfourstepstairsinsidecornerRecipe : BaseRecipe
    {
        public clayblockcyanfourstepstairsinsidecornerRecipe() : base("clayblockcyanfourstepstairsinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockcyanfourstepstairsinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockcyanfourstepstairsinsidecorner : DecorativeType
    {
        public clayblockcyanfourstepstairsinsidecorner() : base("clayblockcyan", "fourstepstairsinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockcyanfourstepstairsinsidecorner.png"))
        {
            this.SideAll = "clayblockcyan";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockcyanfourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockcyanfourstepstairsinsidecornerXMinus() : base("clayblockcyan", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockcyanfourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockcyanfourstepstairsinsidecornerXPlus() : base("clayblockcyan", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockcyanfourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockcyanfourstepstairsinsidecornerZMinus() : base("clayblockcyan", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockcyanfourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockcyanfourstepstairsinsidecornerZPlus() : base("clayblockcyan", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz+");
        }
    }
}