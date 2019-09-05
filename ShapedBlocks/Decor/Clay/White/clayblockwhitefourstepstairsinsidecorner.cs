using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockwhitefourstepstairsinsidecornerRecipe : BaseRecipe
    {
        public clayblockwhitefourstepstairsinsidecornerRecipe() : base("clayblockwhitefourstepstairsinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockwhitefourstepstairsinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockwhitefourstepstairsinsidecorner : DecorativeType
    {
        public clayblockwhitefourstepstairsinsidecorner() : base("clayblockwhite", "fourstepstairsinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockwhitefourstepstairsinsidecorner.png"))
        {
            this.SideAll = "clayblockwhite";
        }
    }

    [NCAPIType]
    public class clayblockwhitefourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockwhitefourstepstairsinsidecornerXMinus() : base("clayblockwhite", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockwhitefourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockwhitefourstepstairsinsidecornerXPlus() : base("clayblockwhite", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockwhitefourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockwhitefourstepstairsinsidecornerZMinus() : base("clayblockwhite", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockwhitefourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockwhitefourstepstairsinsidecornerZPlus() : base("clayblockwhite", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz+");
        }
    }
}