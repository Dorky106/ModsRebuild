using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockredfourstepstairscornerRecipe : BaseRecipe
    {
        public clayblockredfourstepstairscornerRecipe() : base("clayblockredfourstepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockredfourstepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockredfourstepstairscorner : DecorativeType
    {
        public clayblockredfourstepstairscorner() : base("clayblockred", "fourstepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockredfourstepstairscorner.png"))
        {
            this.SideAll = "clayblockred";
        }
    }

    [NCAPIType]
    public class clayblockredfourstepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockredfourstepstairscornerXMinus() : base("clayblockred", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockredfourstepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockredfourstepstairscornerXPlus() : base("clayblockred", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockredfourstepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockredfourstepstairscornerZMinus() : base("clayblockred", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockredfourstepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockredfourstepstairscornerZPlus() : base("clayblockred", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz+");
        }
    }
}