using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class stonebrickscurverotatedRecipe : BaseRecipe
    {
        public stonebrickscurverotatedRecipe() : base("stonebrickscurverotatedrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("stonebricks", 1));
            Result.Add(new InventoryItem("stonebrickscurverotated", 1));
        }
    }

    [NCAPIType]
    public class stonebrickscurverotated : DecorativeType
    {
        public stonebrickscurverotated() : base("stonebricks", "curverotated",
            Utilities.MultiCombine(Entry.ModIconDirectory, "stonebrickscurverotated.png"))
        {
            this.SideAll = "stonebricks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class stonebrickscurverotatedXMinus : DecorativeTypeXMinus
    {
        public stonebrickscurverotatedXMinus() : base("stonebricks", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx-");
        }
    }

    [NCAPIType]
    public class stonebrickscurverotatedXPlus : DecorativeTypeXPlus
    {
        public stonebrickscurverotatedXPlus() : base("stonebricks", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx+");
        }
    }

    [NCAPIType]
    public class stonebrickscurverotatedZMinus : DecorativeTypeZMinus
    {
        public stonebrickscurverotatedZMinus() : base("stonebricks", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz-");
        }
    }

    [NCAPIType]
    public class stonebrickscurverotatedZPlus : DecorativeTypeZPlus
    {
        public stonebrickscurverotatedZPlus() : base("stonebricks", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz+");
        }
    }
}