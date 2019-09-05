using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklightbluetwostepstairsRecipe : BaseRecipe
    {
        public clayblocklightbluetwostepstairsRecipe() : base("clayblocklightbluetwostepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklightbluetwostepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblocklightbluetwostepstairs : DecorativeType
    {
        public clayblocklightbluetwostepstairs() : base("clayblocklightblue", "twostepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklightbluetwostepstairs.png"))
        {
            this.SideAll = "clayblocklightblue";
        }
    }

    [NCAPIType]
    public class clayblocklightbluetwostepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblocklightbluetwostepstairsXMinus() : base("clayblocklightblue", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblocklightbluetwostepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblocklightbluetwostepstairsXPlus() : base("clayblocklightblue", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblocklightbluetwostepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblocklightbluetwostepstairsZMinus() : base("clayblocklightblue", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblocklightbluetwostepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblocklightbluetwostepstairsZPlus() : base("clayblocklightblue", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz+");
        }
    }
}