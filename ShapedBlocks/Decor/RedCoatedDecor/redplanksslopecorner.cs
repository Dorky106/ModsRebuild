using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class redplanksslopecornerRecipe : BaseRecipe
    {
        public redplanksslopecornerRecipe() : base("redplanksslopecornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("redplanks", 1));
            Result.Add(new InventoryItem("redplanksslopecorner", 1));
        }
    }

    [NCAPIType]
    public class redplanksslopecorner : DecorativeType
    {
        public redplanksslopecorner() : base("redplanks", "slopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "redplanksslopecorner.png"))
        {
            this.SideAll = "redplanks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class redplanksslopecornerXMinus : DecorativeTypeXMinus
    {
        public redplanksslopecornerXMinus() : base("redplanks", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx-");
        }
    }

    [NCAPIType]
    public class redplanksslopecornerXPlus : DecorativeTypeXPlus
    {
        public redplanksslopecornerXPlus() : base("redplanks", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx+");
        }
    }

    [NCAPIType]
    public class redplanksslopecornerZMinus : DecorativeTypeZMinus
    {
        public redplanksslopecornerZMinus() : base("redplanks", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz-");
        }
    }

    [NCAPIType]
    public class redplanksslopecornerZPlus : DecorativeTypeZPlus
    {
        public redplanksslopecornerZPlus() : base("redplanks", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz+");
        }
    }
}