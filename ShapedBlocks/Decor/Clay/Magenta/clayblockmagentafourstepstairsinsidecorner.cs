using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockmagentafourstepstairsinsidecornerRecipe : BaseRecipe
    {
        public clayblockmagentafourstepstairsinsidecornerRecipe() : base("clayblockmagentafourstepstairsinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockmagentafourstepstairsinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockmagentafourstepstairsinsidecorner : DecorativeType
    {
        public clayblockmagentafourstepstairsinsidecorner() : base("clayblockmagenta", "fourstepstairsinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockmagentafourstepstairsinsidecorner.png"))
        {
            this.SideAll = "clayblockmagenta";
        }
    }

    [NCAPIType]
    public class clayblockmagentafourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockmagentafourstepstairsinsidecornerXMinus() : base("clayblockmagenta", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockmagentafourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockmagentafourstepstairsinsidecornerXPlus() : base("clayblockmagenta", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockmagentafourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockmagentafourstepstairsinsidecornerZMinus() : base("clayblockmagenta", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockmagentafourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockmagentafourstepstairsinsidecornerZPlus() : base("clayblockmagenta", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz+");
        }
    }
}