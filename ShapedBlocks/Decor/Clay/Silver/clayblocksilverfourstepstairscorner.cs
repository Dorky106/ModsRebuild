using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class ClayblocksilverfourstepstairscornerRecipe : BaseRecipe
    {
        public ClayblocksilverfourstepstairscornerRecipe() : base("clayblocksilverfourstepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocksilverfourstepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class Clayblocksilverfourstepstairscorner : DecorativeType
    {
        public Clayblocksilverfourstepstairscorner() : base("clayblocksilver", "fourstepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocksilverfourstepstairscorner.png"))
        {
            this.SideAll = "clayblocksilver";
        }
    }

    [NCAPIType]
    public class clayblocksilverfourstepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblocksilverfourstepstairscornerXMinus() : base("clayblocksilver", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblocksilverfourstepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblocksilverfourstepstairscornerXPlus() : base("clayblocksilver", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblocksilverfourstepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblocksilverfourstepstairscornerZMinus() : base("clayblocksilver", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblocksilverfourstepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblocksilverfourstepstairscornerZPlus() : base("clayblocksilver", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz+");
        }
    }
}