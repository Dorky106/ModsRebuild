using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockfourstepstairsRecipe : BaseRecipe
    {
        public clayblockfourstepstairsRecipe() : base("clayblockfourstepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockfourstepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockfourstepstairs : DecorativeType
    {
        public clayblockfourstepstairs() : base("clayblock", "fourstepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockfourstepstairs.png"))
        {
            this.SideAll = "clayblock";
        }
    }

    [NCAPIType]
    public class clayblockfourstepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockfourstepstairsXMinus() : base("clayblock", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockfourstepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockfourstepstairsXPlus() : base("clayblock", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockfourstepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockfourstepstairsZMinus() : base("clayblock", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockfourstepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockfourstepstairsZPlus() : base("clayblock", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}