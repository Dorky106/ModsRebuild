using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpurpletwostepstairsRecipe : BaseRecipe
    {
        public clayblockpurpletwostepstairsRecipe() : base("clayblockpurpletwostepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpurpletwostepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockpurpletwostepstairs : DecorativeType
    {
        public clayblockpurpletwostepstairs() : base("clayblockpurple", "twostepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpurpletwostepstairs.png"))
        {
            this.SideAll = "clayblockpurple";
        }
    }

    [NCAPIType]
    public class clayblockpurpletwostepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockpurpletwostepstairsXMinus() : base("clayblockpurple", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockpurpletwostepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockpurpletwostepstairsXPlus() : base("clayblockpurple", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockpurpletwostepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockpurpletwostepstairsZMinus() : base("clayblockpurple", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockpurpletwostepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockpurpletwostepstairsZPlus() : base("clayblockpurple", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz+");
        }
    }
}