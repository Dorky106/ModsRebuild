using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class ClayblocksilverfourstepstairsinsidecornerRecipe : BaseRecipe
    {
        public ClayblocksilverfourstepstairsinsidecornerRecipe() : base("clayblocksilverfourstepstairsinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocksilverfourstepstairsinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class Clayblocksilverfourstepstairsinsidecorner : DecorativeType
    {
        public Clayblocksilverfourstepstairsinsidecorner() : base("clayblocksilver", "fourstepstairsinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocksilverfourstepstairsinsidecorner.png"))
        {
            this.SideAll = "clayblocksilver";
        }
    }

    [NCAPIType]
    public class clayblocksilverfourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblocksilverfourstepstairsinsidecornerXMinus() : base("clayblocksilver", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblocksilverfourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblocksilverfourstepstairsinsidecornerXPlus() : base("clayblocksilver", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblocksilverfourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblocksilverfourstepstairsinsidecornerZMinus() : base("clayblocksilver", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblocksilverfourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblocksilverfourstepstairsinsidecornerZPlus() : base("clayblocksilver", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz+");
        }
    }
}