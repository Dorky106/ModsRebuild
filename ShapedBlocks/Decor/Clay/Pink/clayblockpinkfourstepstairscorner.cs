using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpinkfourstepstairscornerRecipe : BaseRecipe
    {
        public clayblockpinkfourstepstairscornerRecipe() : base("clayblockpinkfourstepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpinkfourstepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockpinkfourstepstairscorner : DecorativeType
    {
        public clayblockpinkfourstepstairscorner() : base("clayblockpink", "fourstepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpinkfourstepstairscorner.png"))
        {
            this.SideAll = "clayblockpink";
        }
    }

    [NCAPIType]
    public class clayblockpinkfourstepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockpinkfourstepstairscornerXMinus() : base("clayblockpink", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockpinkfourstepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockpinkfourstepstairscornerXPlus() : base("clayblockpink", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockpinkfourstepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockpinkfourstepstairscornerZMinus() : base("clayblockpink", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockpinkfourstepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockpinkfourstepstairscornerZPlus() : base("clayblockpink", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz+");
        }
    }
}