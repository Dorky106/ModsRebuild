using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class redplankscurverotatedRecipe : BaseRecipe
    {
        public redplankscurverotatedRecipe() : base("redplankscurverotatedrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("redplanks", 1));
            Result.Add(new InventoryItem("redplankscurverotated", 1));
        }
    }

    [NCAPIType]
    public class redplankscurverotated : DecorativeType
    {
        public redplankscurverotated() : base("redplanks", "curverotated",
            Utilities.MultiCombine(Entry.ModIconDirectory, "redplankscurverotated.png"))
        {
            this.SideAll = "redplanks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class redplankscurverotatedXMinus : DecorativeTypeXMinus
    {
        public redplankscurverotatedXMinus() : base("redplanks", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx-");
        }
    }

    [NCAPIType]
    public class redplankscurverotatedXPlus : DecorativeTypeXPlus
    {
        public redplankscurverotatedXPlus() : base("redplanks", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx+");
        }
    }

    [NCAPIType]
    public class redplankscurverotatedZMinus : DecorativeTypeZMinus
    {
        public redplankscurverotatedZMinus() : base("redplanks", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz-");
        }
    }

    [NCAPIType]
    public class redplankscurverotatedZPlus : DecorativeTypeZPlus
    {
        public redplankscurverotatedZPlus() : base("redplanks", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz+");
        }
    }
}