using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class redplanksslopeinsidecornerRecipe : BaseRecipe
    {
        public redplanksslopeinsidecornerRecipe() : base("redplanksslopeinsidecornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("redplanks", 1));
            Result.Add(new InventoryItem("redplanksslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class redplanksslopeinsidecorner : DecorativeType
    {
        public redplanksslopeinsidecorner() : base("redplanks", "slopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "redplanksslopeinsidecorner.png"))
        {
            this.SideAll = "redplanks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class redplanksslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public redplanksslopeinsidecornerXMinus() : base("redplanks", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class redplanksslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public redplanksslopeinsidecornerXPlus() : base("redplanks", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class redplanksslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public redplanksslopeinsidecornerZMinus() : base("redplanks", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class redplanksslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public redplanksslopeinsidecornerZPlus() : base("redplanks", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz+");
        }
    }
}