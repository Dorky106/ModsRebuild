using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class IronblockfourstepstairsRecipe : BaseRecipe
    {
        public IronblockfourstepstairsRecipe() : base("ironblockfourstepstairsrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("ironblock", 1));
            Result.Add(new InventoryItem("ironblockfourstepstairs", 1));
        }
    }

    [NCAPIType]
    public class Ironblockfourstepstairs : DecorativeType
    {
        public Ironblockfourstepstairs() : base("ironblock", "fourstepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "ironblockfourstepstairs.png"))
        {
            this.SideAll = "ironblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class ironblockfourstepstairsXMinus : DecorativeTypeXMinus
    {
        public ironblockfourstepstairsXMinus() : base("ironblock", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class ironblockfourstepstairsXPlus : DecorativeTypeXPlus
    {
        public ironblockfourstepstairsXPlus() : base("ironblock", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class ironblockfourstepstairsZMinus : DecorativeTypeZMinus
    {
        public ironblockfourstepstairsZMinus() : base("ironblock", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class ironblockfourstepstairsZPlus : DecorativeTypeZPlus
    {
        public ironblockfourstepstairsZPlus() : base("ironblock", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}