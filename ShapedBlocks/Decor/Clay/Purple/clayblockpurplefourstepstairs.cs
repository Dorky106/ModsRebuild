using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpurplefourstepstairsRecipe : BaseRecipe
    {
        public clayblockpurplefourstepstairsRecipe() : base("clayblockpurplefourstepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpurplefourstepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockpurplefourstepstairs : DecorativeType
    {
        public clayblockpurplefourstepstairs() : base("clayblockpurple", "fourstepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpurplefourstepstairs.png"))
        {
            this.SideAll = "clayblockpurple";
        }
    }

    [NCAPIType]
    public class clayblockpurplefourstepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockpurplefourstepstairsXMinus() : base("clayblockpurple", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockpurplefourstepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockpurplefourstepstairsXPlus() : base("clayblockpurple", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockpurplefourstepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockpurplefourstepstairsZMinus() : base("clayblockpurple", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockpurplefourstepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockpurplefourstepstairsZPlus() : base("clayblockpurple", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}