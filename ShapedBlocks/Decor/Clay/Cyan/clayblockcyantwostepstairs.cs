using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockcyantwostepstairsRecipe : BaseRecipe
    {
        public clayblockcyantwostepstairsRecipe() : base("clayblockcyantwostepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockcyantwostepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockcyantwostepstairs : DecorativeType
    {
        public clayblockcyantwostepstairs() : base("clayblockcyan", "twostepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockcyantwostepstairs.png"))
        {
            this.SideAll = "clayblockcyan";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockcyantwostepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockcyantwostepstairsXMinus() : base("clayblockcyan", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockcyantwostepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockcyantwostepstairsXPlus() : base("clayblockcyan", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockcyantwostepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockcyantwostepstairsZMinus() : base("clayblockcyan", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockcyantwostepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockcyantwostepstairsZPlus() : base("clayblockcyan", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz+");
        }
    }
}