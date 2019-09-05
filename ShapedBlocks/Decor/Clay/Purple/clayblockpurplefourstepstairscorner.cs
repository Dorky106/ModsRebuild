using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpurplefourstepstairscornerRecipe : BaseRecipe
    {
        public clayblockpurplefourstepstairscornerRecipe() : base("clayblockpurplefourstepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpurplefourstepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockpurplefourstepstairscorner : DecorativeType
    {
        public clayblockpurplefourstepstairscorner() : base("clayblockpurple", "fourstepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpurplefourstepstairscorner.png"))
        {
            this.SideAll = "clayblockpurple";
        }
    }

    [NCAPIType]
    public class clayblockpurplefourstepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockpurplefourstepstairscornerXMinus() : base("clayblockpurple", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockpurplefourstepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockpurplefourstepstairscornerXPlus() : base("clayblockpurple", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockpurplefourstepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockpurplefourstepstairscornerZMinus() : base("clayblockpurple", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockpurplefourstepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockpurplefourstepstairscornerZPlus() : base("clayblockpurple", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz+");
        }
    }
}