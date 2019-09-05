using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockredfourstepstairsRecipe : BaseRecipe
    {
        public clayblockredfourstepstairsRecipe() : base("clayblockredfourstepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockredfourstepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockredfourstepstairs : DecorativeType
    {
        public clayblockredfourstepstairs() : base("clayblockred", "fourstepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockredfourstepstairs.png"))
        {
            this.SideAll = "clayblockred";
        }
    }

    [NCAPIType]
    public class clayblockredfourstepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockredfourstepstairsXMinus() : base("clayblockred", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockredfourstepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockredfourstepstairsXPlus() : base("clayblockred", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockredfourstepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockredfourstepstairsZMinus() : base("clayblockred", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockredfourstepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockredfourstepstairsZPlus() : base("clayblockred", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}