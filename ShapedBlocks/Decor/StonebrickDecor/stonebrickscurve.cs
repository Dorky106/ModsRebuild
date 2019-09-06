using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class StonebrickscurveRecipe : BaseRecipe
    {
        public StonebrickscurveRecipe() : base("stonebrickscurverecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("stonebricks", 1));
            Result.Add(new InventoryItem("stonebrickscurve", 1));
        }
    }

    [NCAPIType]
    public class Stonebrickscurve : DecorativeType
    {
        public Stonebrickscurve() : base("stonebricks", "curve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "stonebrickscurve.png"))
        {
            this.SideAll = "stonebricks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class StonebrickscurveXMinus : DecorativeTypeXMinus
    {
        public StonebrickscurveXMinus() : base("stonebricks", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex-");
        }
    }

    [NCAPIType]
    public class StonebrickscurveXPlus : DecorativeTypeXPlus
    {
        public StonebrickscurveXPlus() : base("stonebricks", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex+");
        }
    }

    [NCAPIType]
    public class StonebrickscurveZMinus : DecorativeTypeZMinus
    {
        public StonebrickscurveZMinus() : base("stonebricks", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez-");
        }
    }

    [NCAPIType]
    public class StonebrickscurveZPlus : DecorativeTypeZPlus
    {
        public StonebrickscurveZPlus() : base("stonebricks", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez+");
        }
    }
}