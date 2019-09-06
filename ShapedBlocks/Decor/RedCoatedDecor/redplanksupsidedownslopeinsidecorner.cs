using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class redplanksupsidedownslopeinsidecornerRecipe : BaseRecipe
    {
        public redplanksupsidedownslopeinsidecornerRecipe() : base("redplanksupsidedownslopeinsidecornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("redplanks", 1));
            Result.Add(new InventoryItem("redplanksupsidedownslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class redplanksupsidedownslopeinsidecorner : DecorativeType
    {
        public redplanksupsidedownslopeinsidecorner() : base("redplanks", "upsidedownslopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "redplanksupsidedownslopeinsidecorner.png"))
        {
            this.SideAll = "redplanks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class redplanksupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public redplanksupsidedownslopeinsidecornerXMinus() : base("redplanks", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class redplanksupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public redplanksupsidedownslopeinsidecornerXPlus() : base("redplanks", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class redplanksupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public redplanksupsidedownslopeinsidecornerZMinus() : base("redplanks", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class redplanksupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public redplanksupsidedownslopeinsidecornerZPlus() : base("redplanks", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz+");
        }
    }
}