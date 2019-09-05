using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpinkfourstepstairsinsidecornerRecipe : BaseRecipe
    {
        public clayblockpinkfourstepstairsinsidecornerRecipe() : base("clayblockpinkfourstepstairsinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpinkfourstepstairsinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockpinkfourstepstairsinsidecorner : DecorativeType
    {
        public clayblockpinkfourstepstairsinsidecorner() : base("clayblockpink", "fourstepstairsinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpinkfourstepstairsinsidecorner.png"))
        {
            this.SideAll = "clayblockpink";
        }
    }

    [NCAPIType]
    public class clayblockpinkfourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockpinkfourstepstairsinsidecornerXMinus() : base("clayblockpink", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockpinkfourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockpinkfourstepstairsinsidecornerXPlus() : base("clayblockpink", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockpinkfourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockpinkfourstepstairsinsidecornerZMinus() : base("clayblockpink", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockpinkfourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockpinkfourstepstairsinsidecornerZPlus() : base("clayblockpink", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz+");
        }
    }
}