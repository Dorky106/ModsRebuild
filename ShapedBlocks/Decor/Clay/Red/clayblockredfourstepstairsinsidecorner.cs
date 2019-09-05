using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockredfourstepstairsinsidecornerRecipe : BaseRecipe
    {
        public clayblockredfourstepstairsinsidecornerRecipe() : base("clayblockredfourstepstairsinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockredfourstepstairsinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockredfourstepstairsinsidecorner : DecorativeType
    {
        public clayblockredfourstepstairsinsidecorner() : base("clayblockred", "fourstepstairsinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockredfourstepstairsinsidecorner.png"))
        {
            this.SideAll = "clayblockred";
        }
    }

    [NCAPIType]
    public class clayblockredfourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockredfourstepstairsinsidecornerXMinus() : base("clayblockred", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockredfourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockredfourstepstairsinsidecornerXPlus() : base("clayblockred", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockredfourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockredfourstepstairsinsidecornerZMinus() : base("clayblockred", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockredfourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockredfourstepstairsinsidecornerZPlus() : base("clayblockred", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz+");
        }
    }
}