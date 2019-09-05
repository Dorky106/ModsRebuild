using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class planksupsidedowncurveRecipe : BaseRecipe
    {
        public planksupsidedowncurveRecipe() : base("planksupsidedowncurverecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("planks", 1));
            Result.Add(new InventoryItem("planksupsidedowncurve", 1));
        }
    }

    [NCAPIType]
    public class planksupsidedowncurve : DecorativeType
    {
        public planksupsidedowncurve() : base("planks", "upsidedowncurve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "planksupsidedowncurve.png"))
        {
            this.SideAll = "planks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class planksupsidedowncurveXMinus : DecorativeTypeXMinus
    {
        public planksupsidedowncurveXMinus() : base("planks", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex-");
        }
    }

    [NCAPIType]
    public class planksupsidedowncurveXPlus : DecorativeTypeXPlus
    {
        public planksupsidedowncurveXPlus() : base("planks", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex+");
        }
    }

    [NCAPIType]
    public class planksupsidedowncurveZMinus : DecorativeTypeZMinus
    {
        public planksupsidedowncurveZMinus() : base("planks", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez-");
        }
    }

    [NCAPIType]
    public class planksupsidedowncurveZPlus : DecorativeTypeZPlus
    {
        public planksupsidedowncurveZPlus() : base("planks", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez+");
        }
    }
}