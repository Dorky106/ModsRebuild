using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbluefourstepstairscornerRecipe : BaseRecipe
    {
        public clayblockbluefourstepstairscornerRecipe() : base("clayblockbluefourstepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbluefourstepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockbluefourstepstairscorner : DecorativeType
    {
        public clayblockbluefourstepstairscorner() : base("clayblockblue", "fourstepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbluefourstepstairscorner.png"))
        {
            this.SideAll = "clayblockblue";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbluefourstepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockbluefourstepstairscornerXMinus() : base("clayblockblue", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockbluefourstepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockbluefourstepstairscornerXPlus() : base("clayblockblue", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockbluefourstepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockbluefourstepstairscornerZMinus() : base("clayblockblue", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockbluefourstepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockbluefourstepstairscornerZPlus() : base("clayblockblue", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz+");
        }
    }
}