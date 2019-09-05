using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class PlankscurverotatedRecipe : BaseRecipe
    {
        public PlankscurverotatedRecipe() : base("plankscurverotatedrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("planks", 1));
            Result.Add(new InventoryItem("plankscurverotated", 1));
        }
    }

    [NCAPIType]
    public class Plankscurverotated : DecorativeType
    {
        public Plankscurverotated() : base("planks", "curverotated",
            Utilities.MultiCombine(Entry.ModIconDirectory, "plankscurverotated.png"))
        {
            this.SideAll = "planks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class plankscurverotatedXMinus : DecorativeTypeXMinus
    {
        public plankscurverotatedXMinus() : base("planks", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx-");
        }
    }

    [NCAPIType]
    public class plankscurverotatedXPlus : DecorativeTypeXPlus
    {
        public plankscurverotatedXPlus() : base("planks", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx+");
        }
    }

    [NCAPIType]
    public class plankscurverotatedZMinus : DecorativeTypeZMinus
    {
        public plankscurverotatedZMinus() : base("planks", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz-");
        }
    }

    [NCAPIType]
    public class plankscurverotatedZPlus : DecorativeTypeZPlus
    {
        public plankscurverotatedZPlus() : base("planks", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz+");
        }
    }
}