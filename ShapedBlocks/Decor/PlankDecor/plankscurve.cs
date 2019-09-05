using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class PlankscurveRecipe : BaseRecipe
    {
        public PlankscurveRecipe() : base("plankscurverecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("planks", 1));
            Result.Add(new InventoryItem("plankscurve", 1));
        }
    }

    [NCAPIType]
    public class Plankscurve : DecorativeType
    {
        public Plankscurve() : base("planks", "curve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "plankscurve.png"))
        {
            this.SideAll = "planks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class plankscurveXMinus : DecorativeTypeXMinus
    {
        public plankscurveXMinus() : base("planks", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex-");
        }
    }

    [NCAPIType]
    public class plankscurveXPlus : DecorativeTypeXPlus
    {
        public plankscurveXPlus() : base("planks", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex+");
        }
    }

    [NCAPIType]
    public class plankscurveZMinus : DecorativeTypeZMinus
    {
        public plankscurveZMinus() : base("planks", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez-");
        }
    }

    [NCAPIType]
    public class plankscurveZPlus : DecorativeTypeZPlus
    {
        public plankscurveZPlus() : base("planks", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez+");
        }
    }
}