using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class redplankstwostepstairscornerRecipe : BaseRecipe
    {
        public redplankstwostepstairscornerRecipe() : base("redplankstwostepstairscornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("redplanks", 1));
            Result.Add(new InventoryItem("redplankstwostepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class redplankstwostepstairscorner : DecorativeType
    {
        public redplankstwostepstairscorner() : base("redplanks", "twostepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "redplankstwostepstairscorner.png"))
        {
            this.SideAll = "redplanks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class redplankstwostepstairscornerXMinus : DecorativeTypeXMinus
    {
        public redplankstwostepstairscornerXMinus() : base("redplanks", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx-");
        }
    }

    [NCAPIType]
    public class redplankstwostepstairscornerXPlus : DecorativeTypeXPlus
    {
        public redplankstwostepstairscornerXPlus() : base("redplanks", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx+");
        }
    }

    [NCAPIType]
    public class redplankstwostepstairscornerZMinus : DecorativeTypeZMinus
    {
        public redplankstwostepstairscornerZMinus() : base("redplanks", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz-");
        }
    }

    [NCAPIType]
    public class redplankstwostepstairscornerZPlus : DecorativeTypeZPlus
    {
        public redplankstwostepstairscornerZPlus() : base("redplanks", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz+");
        }
    }
}