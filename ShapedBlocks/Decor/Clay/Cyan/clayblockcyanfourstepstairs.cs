using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockcyanfourstepstairsRecipe : BaseRecipe
    {
        public clayblockcyanfourstepstairsRecipe() : base("clayblockcyanfourstepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockcyanfourstepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockcyanfourstepstairs : DecorativeType
    {
        public clayblockcyanfourstepstairs() : base("clayblockcyan", "fourstepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockcyanfourstepstairs.png"))
        {
            this.SideAll = "clayblockcyan";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockcyanfourstepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockcyanfourstepstairsXMinus() : base("clayblockcyan", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockcyanfourstepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockcyanfourstepstairsXPlus() : base("clayblockcyan", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockcyanfourstepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockcyanfourstepstairsZMinus() : base("clayblockcyan", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockcyanfourstepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockcyanfourstepstairsZPlus() : base("clayblockcyan", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}