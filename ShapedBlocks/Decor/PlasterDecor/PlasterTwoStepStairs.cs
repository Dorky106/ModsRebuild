using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class plasterblocktwostepstairsRecipe : BaseRecipe
    {
        public plasterblocktwostepstairsRecipe() : base("plasterblocktwostepstairsrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("plasterblock", 1));
            Result.Add(new InventoryItem("plasterblocktwostepstairs", 1));
        }
    }

    [NCAPIType]
    public class plasterblocktwostepstairs : DecorativeType
    {
        public plasterblocktwostepstairs() : base("plasterblock", "twostepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "plasterblocktwostepstairs.png"))
        {
            this.SideAll = "plasterblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class plasterblocktwostepstairsXMinus : DecorativeTypeXMinus
    {
        public plasterblocktwostepstairsXMinus() : base("plasterblock", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx-");
        }
    }

    [NCAPIType]
    public class plasterblocktwostepstairsXPlus : DecorativeTypeXPlus
    {
        public plasterblocktwostepstairsXPlus() : base("plasterblock", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx+");
        }
    }

    [NCAPIType]
    public class plasterblocktwostepstairsZMinus : DecorativeTypeZMinus
    {
        public plasterblocktwostepstairsZMinus() : base("plasterblock", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz-");
        }
    }

    [NCAPIType]
    public class plasterblocktwostepstairsZPlus : DecorativeTypeZPlus
    {
        public plasterblocktwostepstairsZPlus() : base("plasterblock", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz+");
        }
    }
}