using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocksilvertwostepstairsRecipe : BaseRecipe
    {
        public clayblocksilvertwostepstairsRecipe() : base("clayblocksilvertwostepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocksilvertwostepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblocksilvertwostepstairs : DecorativeType
    {
        public clayblocksilvertwostepstairs() : base("clayblocksilver", "twostepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocksilvertwostepstairs.png"))
        {
            this.SideAll = "clayblocksilver";
        }
    }

    [NCAPIType]
    public class clayblocksilvertwostepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblocksilvertwostepstairsXMinus() : base("clayblocksilver", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblocksilvertwostepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblocksilvertwostepstairsXPlus() : base("clayblocksilver", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblocksilvertwostepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblocksilvertwostepstairsZMinus() : base("clayblocksilver", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblocksilvertwostepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblocksilvertwostepstairsZPlus() : base("clayblocksilver", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz+");
        }
    }
}