using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbluefourstepstairsinsidecornerRecipe : BaseRecipe
    {
        public clayblockbluefourstepstairsinsidecornerRecipe() : base("clayblockbluefourstepstairsinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbluefourstepstairsinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockbluefourstepstairsinsidecorner : DecorativeType
    {
        public clayblockbluefourstepstairsinsidecorner() : base("clayblockblue", "fourstepstairsinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbluefourstepstairsinsidecorner.png"))
        {
            this.SideAll = "clayblockblue";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbluefourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockbluefourstepstairsinsidecornerXMinus() : base("clayblockblue", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockbluefourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockbluefourstepstairsinsidecornerXPlus() : base("clayblockblue", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockbluefourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockbluefourstepstairsinsidecornerZMinus() : base("clayblockblue", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockbluefourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockbluefourstepstairsinsidecornerZPlus() : base("clayblockblue", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz+");
        }
    }
}