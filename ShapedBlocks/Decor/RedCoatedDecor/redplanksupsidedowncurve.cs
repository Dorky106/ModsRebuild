using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class redplanksupsidedowncurveRecipe : BaseRecipe
    {
        public redplanksupsidedowncurveRecipe() : base("redplanksupsidedowncurverecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("redplanks", 1));
            Result.Add(new InventoryItem("redplanksupsidedowncurve", 1));
        }
    }

    [NCAPIType]
    public class redplanksupsidedowncurve : DecorativeType
    {
        public redplanksupsidedowncurve() : base("redplanks", "upsidedowncurve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "redplanksupsidedowncurve.png"))
        {
            this.SideAll = "redplanks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class redplanksupsidedowncurveXMinus : DecorativeTypeXMinus
    {
        public redplanksupsidedowncurveXMinus() : base("redplanks", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex-");
        }
    }

    [NCAPIType]
    public class redplanksupsidedowncurveXPlus : DecorativeTypeXPlus
    {
        public redplanksupsidedowncurveXPlus() : base("redplanks", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex+");
        }
    }

    [NCAPIType]
    public class redplanksupsidedowncurveZMinus : DecorativeTypeZMinus
    {
        public redplanksupsidedowncurveZMinus() : base("redplanks", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez-");
        }
    }

    [NCAPIType]
    public class redplanksupsidedowncurveZPlus : DecorativeTypeZPlus
    {
        public redplanksupsidedowncurveZPlus() : base("redplanks", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez+");
        }
    }
}