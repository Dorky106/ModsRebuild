using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbluefourstepstairsRecipe : BaseRecipe
    {
        public clayblockbluefourstepstairsRecipe() : base("clayblockbluefourstepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbluefourstepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockbluefourstepstairs : DecorativeType
    {
        public clayblockbluefourstepstairs() : base("clayblockblue", "fourstepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbluefourstepstairs.png"))
        {
            this.SideAll = "clayblockblue";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbluefourstepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockbluefourstepstairsXMinus() : base("clayblockblue", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockbluefourstepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockbluefourstepstairsXPlus() : base("clayblockblue", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockbluefourstepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockbluefourstepstairsZMinus() : base("clayblockblue", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockbluefourstepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockbluefourstepstairsZPlus() : base("clayblockblue", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}