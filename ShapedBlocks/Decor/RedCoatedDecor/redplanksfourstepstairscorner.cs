using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class redplanksfourstepstairscornerRecipe : BaseRecipe
    {
        public redplanksfourstepstairscornerRecipe() : base("redplanksfourstepstairscornerrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("redplanks", 1));
            Result.Add(new InventoryItem("redplanksfourstepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class redplanksfourstepstairscorner : DecorativeType
    {
        public redplanksfourstepstairscorner() : base("redplanks", "fourstepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "redplanksfourstepstairscorner.png"))
        {
            this.SideAll = "redplanks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class redplanksfourstepstairscornerXMinus : DecorativeTypeXMinus
    {
        public redplanksfourstepstairscornerXMinus() : base("redplanks", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx-");
        }
    }

    [NCAPIType]
    public class redplanksfourstepstairscornerXPlus : DecorativeTypeXPlus
    {
        public redplanksfourstepstairscornerXPlus() : base("redplanks", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx+");
        }
    }

    [NCAPIType]
    public class redplanksfourstepstairscornerZMinus : DecorativeTypeZMinus
    {
        public redplanksfourstepstairscornerZMinus() : base("redplanks", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz-");
        }
    }

    [NCAPIType]
    public class redplanksfourstepstairscornerZPlus : DecorativeTypeZPlus
    {
        public redplanksfourstepstairscornerZPlus() : base("redplanks", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz+");
        }
    }
}