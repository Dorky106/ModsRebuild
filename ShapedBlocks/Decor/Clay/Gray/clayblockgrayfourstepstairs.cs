using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgrayfourstepstairsRecipe : BaseRecipe
    {
        public clayblockgrayfourstepstairsRecipe() : base("clayblockgrayfourstepstairsrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgrayfourstepstairs", 1));
        }
    }

    [NCAPIType]
    public class clayblockgrayfourstepstairs : DecorativeType
    {
        public clayblockgrayfourstepstairs() : base("clayblockgray", "fourstepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgrayfourstepstairs.png"))
        {
            this.SideAll = "clayblockgray";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgrayfourstepstairsXMinus : DecorativeTypeXMinus
    {
        public clayblockgrayfourstepstairsXMinus() : base("clayblockgray", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class clayblockgrayfourstepstairsXPlus : DecorativeTypeXPlus
    {
        public clayblockgrayfourstepstairsXPlus() : base("clayblockgray", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class clayblockgrayfourstepstairsZMinus : DecorativeTypeZMinus
    {
        public clayblockgrayfourstepstairsZMinus() : base("clayblockgray", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class clayblockgrayfourstepstairsZPlus : DecorativeTypeZPlus
    {
        public clayblockgrayfourstepstairsZPlus() : base("clayblockgray", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}