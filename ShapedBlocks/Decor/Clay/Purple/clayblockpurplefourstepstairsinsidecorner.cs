using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpurplefourstepstairsinsidecornerRecipe : BaseRecipe
    {
        public clayblockpurplefourstepstairsinsidecornerRecipe() : base("clayblockpurplefourstepstairsinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpurplefourstepstairsinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockpurplefourstepstairsinsidecorner : DecorativeType
    {
        public clayblockpurplefourstepstairsinsidecorner() : base("clayblockpurple", "fourstepstairsinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpurplefourstepstairsinsidecorner.png"))
        {
            this.SideAll = "clayblockpurple";
        }
    }

    [NCAPIType]
    public class clayblockpurplefourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockpurplefourstepstairsinsidecornerXMinus() : base("clayblockpurple", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockpurplefourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockpurplefourstepstairsinsidecornerXPlus() : base("clayblockpurple", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockpurplefourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockpurplefourstepstairsinsidecornerZMinus() : base("clayblockpurple", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockpurplefourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockpurplefourstepstairsinsidecornerZPlus() : base("clayblockpurple", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz+");
        }
    }
}