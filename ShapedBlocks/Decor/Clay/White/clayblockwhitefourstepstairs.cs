using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockwhitefourstepstairsRecipe : BaseRecipe
    {
        public clayblockwhitefourstepstairsRecipe() : base("clayblockwhitefourstepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockwhitefourstepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockwhitefourstepstairs : DecorativeType
    {
        public clayblockwhitefourstepstairs() : base("clayblockwhite", "fourstepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockwhitefourstepstairs.png"))
        {
            this.SideAll = "clayblockwhite";
        }
    }

    [NCAPIType]
    public class clayblockwhitefourstepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockwhitefourstepstairsXMinus() : base("clayblockwhite", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockwhitefourstepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockwhitefourstepstairsXPlus() : base("clayblockwhite", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockwhitefourstepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockwhitefourstepstairsZMinus() : base("clayblockwhite", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockwhitefourstepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockwhitefourstepstairsZPlus() : base("clayblockwhite", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}