using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class redplanksslopeRecipe : BaseRecipe
    {
        public redplanksslopeRecipe() : base("redplankssloperecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("redplanks", 1));
            Result.Add(new InventoryItem("redplanksslope", 1));
        }
    }

    [NCAPIType]
    public class redplanksslope : DecorativeType
    {
        public redplanksslope() : base("redplanks", "slope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "redplanksslope.png"))
        {
            this.SideAll = "redplanks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class redplanksslopeXMinus : DecorativeTypeXMinus
    {
        public redplanksslopeXMinus() : base("redplanks", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class redplanksslopeXPlus : DecorativeTypeXPlus
    {
        public redplanksslopeXPlus() : base("redplanks", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class redplanksslopeZMinus : DecorativeTypeZMinus
    {
        public redplanksslopeZMinus() : base("redplanks", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class redplanksslopeZPlus : DecorativeTypeZPlus
    {
        public redplanksslopeZPlus() : base("redplanks", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}