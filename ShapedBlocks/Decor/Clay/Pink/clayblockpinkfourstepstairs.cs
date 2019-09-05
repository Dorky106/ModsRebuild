using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpinkfourstepstairsRecipe : BaseRecipe
    {
        public clayblockpinkfourstepstairsRecipe() : base("clayblockpinkfourstepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpinkfourstepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockpinkfourstepstairs : DecorativeType
    {
        public clayblockpinkfourstepstairs() : base("clayblockpink", "fourstepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpinkfourstepstairs.png"))
        {
            this.SideAll = "clayblockpink";
        }
    }

    [NCAPIType]
    public class clayblockpinkfourstepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockpinkfourstepstairsXMinus() : base("clayblockpink", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockpinkfourstepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockpinkfourstepstairsXPlus() : base("clayblockpink", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockpinkfourstepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockpinkfourstepstairsZMinus() : base("clayblockpink", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockpinkfourstepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockpinkfourstepstairsZPlus() : base("clayblockpink", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}