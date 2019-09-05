using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgreenfourstepstairsRecipe : BaseRecipe
    {
        public clayblockgreenfourstepstairsRecipe() : base("clayblockgreenfourstepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgreenfourstepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockgreenfourstepstairs : DecorativeType
    {
        public clayblockgreenfourstepstairs() : base("clayblockgreen", "fourstepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgreenfourstepstairs.png"))
        {
            this.SideAll = "clayblockgreen";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgreenfourstepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockgreenfourstepstairsXMinus() : base("clayblockgreen", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockgreenfourstepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockgreenfourstepstairsXPlus() : base("clayblockgreen", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockgreenfourstepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockgreenfourstepstairsZMinus() : base("clayblockgreen", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockgreenfourstepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockgreenfourstepstairsZPlus() : base("clayblockgreen", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}