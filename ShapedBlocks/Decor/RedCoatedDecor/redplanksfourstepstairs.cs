using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class redplanksfourstepstairsRecipe : BaseRecipe
    {
        public redplanksfourstepstairsRecipe() : base("redplanksfourstepstairsrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("redplanks", 1));
            Result.Add(new InventoryItem("redplanksfourstepstairs", 1));
        }
    }

    [NCAPIType]
    public class redplanksfourstepstairs : DecorativeType
    {
        public redplanksfourstepstairs() : base("redplanks", "fourstepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "redplanksfourstepstairs.png"))
        {
            this.SideAll = "redplanks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class redplanksfourstepstairsXMinus : DecorativeTypeXMinus
    {
        public redplanksfourstepstairsXMinus() : base("redplanks", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class redplanksfourstepstairsXPlus : DecorativeTypeXPlus
    {
        public redplanksfourstepstairsXPlus() : base("redplanks", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class redplanksfourstepstairsZMinus : DecorativeTypeZMinus
    {
        public redplanksfourstepstairsZMinus() : base("redplanks", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class redplanksfourstepstairsZPlus : DecorativeTypeZPlus
    {
        public redplanksfourstepstairsZPlus() : base("redplanks", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}