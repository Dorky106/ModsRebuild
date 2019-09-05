using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocksilverfourstepstairsRecipe : BaseRecipe
    {
        public clayblocksilverfourstepstairsRecipe() : base("clayblocksilverfourstepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocksilverfourstepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblocksilverfourstepstairs : DecorativeType
    {
        public clayblocksilverfourstepstairs() : base("clayblocksilver", "fourstepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocksilverfourstepstairs.png"))
        {
            this.SideAll = "clayblocksilver";
        }
    }

    [NCAPIType]
    public class clayblocksilverfourstepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblocksilverfourstepstairsXMinus() : base("clayblocksilver", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblocksilverfourstepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblocksilverfourstepstairsXPlus() : base("clayblocksilver", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblocksilverfourstepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblocksilverfourstepstairsZMinus() : base("clayblocksilver", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblocksilverfourstepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblocksilverfourstepstairsZPlus() : base("clayblocksilver", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}