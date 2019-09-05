using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockmagentafourstepstairsRecipe : BaseRecipe
    {
        public clayblockmagentafourstepstairsRecipe() : base("clayblockmagentafourstepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockmagentafourstepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockmagentafourstepstairs : DecorativeType
    {
        public clayblockmagentafourstepstairs() : base("clayblockmagenta", "fourstepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockmagentafourstepstairs.png"))
        {
            this.SideAll = "clayblockmagenta";
        }
    }

    [NCAPIType]
    public class clayblockmagentafourstepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockmagentafourstepstairsXMinus() : base("clayblockmagenta", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockmagentafourstepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockmagentafourstepstairsXPlus() : base("clayblockmagenta", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockmagentafourstepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockmagentafourstepstairsZMinus() : base("clayblockmagenta", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockmagentafourstepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockmagentafourstepstairsZPlus() : base("clayblockmagenta", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}