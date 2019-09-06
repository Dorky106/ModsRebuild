using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class redplanksupsidedownslopeRecipe : BaseRecipe
    {
        public redplanksupsidedownslopeRecipe() : base("redplanksupsidedownsloperecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("redplanks", 1));
            Result.Add(new InventoryItem("redplanksupsidedownslope", 1));
        }
    }

    [NCAPIType]
    public class redplanksupsidedownslope : DecorativeType
    {
        public redplanksupsidedownslope() : base("redplanks", "upsidedownslope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "redplanksupsidedownslope.png"))
        {
            this.SideAll = "redplanks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class redplanksupsidedownslopeXMinus : DecorativeTypeXMinus
    {
        public redplanksupsidedownslopeXMinus() : base("redplanks", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex-");
        }
    }

    [NCAPIType]
    public class redplanksupsidedownslopeXPlus : DecorativeTypeXPlus
    {
        public redplanksupsidedownslopeXPlus() : base("redplanks", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex+");
        }
    }

    [NCAPIType]
    public class redplanksupsidedownslopeZMinus : DecorativeTypeZMinus
    {
        public redplanksupsidedownslopeZMinus() : base("redplanks", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez-");
        }
    }

    [NCAPIType]
    public class redplanksupsidedownslopeZPlus : DecorativeTypeZPlus
    {
        public redplanksupsidedownslopeZPlus() : base("redplanks", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez+");
        }
    }
}