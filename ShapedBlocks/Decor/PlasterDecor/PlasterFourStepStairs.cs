using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class plasterblockfourstepstairsRecipe : BaseRecipe
    {
        public plasterblockfourstepstairsRecipe() : base("plasterblockfourstepstairsrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("plasterblock", 1));
            Result.Add(new InventoryItem("plasterblockfourstepstairs", 1));
        }
    }

    [NCAPIType]
    public class plasterblockfourstepstairs : DecorativeType
    {
        public plasterblockfourstepstairs() : base("plasterblock", "fourstepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "plasterblockfourstepstairs.png"))
        {
            this.SideAll = "plasterblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class plasterblockfourstepstairsXMinus : DecorativeTypeXMinus
    {
        public plasterblockfourstepstairsXMinus() : base("plasterblock", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class plasterblockfourstepstairsXPlus : DecorativeTypeXPlus
    {
        public plasterblockfourstepstairsXPlus() : base("plasterblock", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class plasterblockfourstepstairsZMinus : DecorativeTypeZMinus
    {
        public plasterblockfourstepstairsZMinus() : base("plasterblock", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class plasterblockfourstepstairsZPlus : DecorativeTypeZPlus
    {
        public plasterblockfourstepstairsZPlus() : base("plasterblock", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}