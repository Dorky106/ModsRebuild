using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpinktwostepstairsRecipe : BaseRecipe
    {
        public clayblockpinktwostepstairsRecipe() : base("clayblockpinktwostepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpinktwostepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockpinktwostepstairs : DecorativeType
    {
        public clayblockpinktwostepstairs() : base("clayblockpink", "twostepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpinktwostepstairs.png"))
        {
            this.SideAll = "clayblockpink";
        }
    }

    [NCAPIType]
    public class clayblockpinktwostepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockpinktwostepstairsXMinus() : base("clayblockpink", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockpinktwostepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockpinktwostepstairsXPlus() : base("clayblockpink", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockpinktwostepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockpinktwostepstairsZMinus() : base("clayblockpink", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockpinktwostepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockpinktwostepstairsZPlus() : base("clayblockpink", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz+");
        }
    }
}