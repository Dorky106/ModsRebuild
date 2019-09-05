using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class redplanksfourstepstairsinsidecornerRecipe : BaseRecipe
    {
        public redplanksfourstepstairsinsidecornerRecipe() : base("redplanksfourstepstairsinsidecornerrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("redplanks", 1));
            Result.Add(new InventoryItem("redplanksfourstepstairsinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class redplanksfourstepstairsinsidecorner : DecorativeType
    {
        public redplanksfourstepstairsinsidecorner() : base("redplanks", "fourstepstairsinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "redplanksfourstepstairsinsidecorner.png"))
        {
            this.SideAll = "redplanks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class redplanksfourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
    {
        public redplanksfourstepstairsinsidecornerXMinus() : base("redplanks", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx-");
        }
    }

    [NCAPIType]
    public class redplanksfourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
    {
        public redplanksfourstepstairsinsidecornerXPlus() : base("redplanks", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx+");
        }
    }

    [NCAPIType]
    public class redplanksfourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
    {
        public redplanksfourstepstairsinsidecornerZMinus() : base("redplanks", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz-");
        }
    }

    [NCAPIType]
    public class redplanksfourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
    {
        public redplanksfourstepstairsinsidecornerZPlus() : base("redplanks", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz+");
        }
    }
}