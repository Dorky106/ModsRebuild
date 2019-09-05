using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class redplankscurveRecipe : BaseRecipe
    {
        public redplankscurveRecipe() : base("redplankscurverecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("redplanks", 1));
            Result.Add(new InventoryItem("redplankscurve", 1));
        }
    }

    [NCAPIType]
    public class redplankscurve : DecorativeType
    {
        public redplankscurve() : base("redplanks", "curve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "redplankscurve.png"))
        {
            this.SideAll = "redplanks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class redplankscurveXMinus : DecorativeTypeXMinus
    {
        public redplankscurveXMinus() : base("redplanks", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex-");
        }
    }

    [NCAPIType]
    public class redplankscurveXPlus : DecorativeTypeXPlus
    {
        public redplankscurveXPlus() : base("redplanks", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex+");
        }
    }

    [NCAPIType]
    public class redplankscurveZMinus : DecorativeTypeZMinus
    {
        public redplankscurveZMinus() : base("redplanks", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez-");
        }
    }

    [NCAPIType]
    public class redplankscurveZPlus : DecorativeTypeZPlus
    {
        public redplankscurveZPlus() : base("redplanks", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez+");
        }
    }
}