using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class plasterblockcurverotatedRecipe : BaseRecipe
    {
        public plasterblockcurverotatedRecipe() : base("plasterblockcurverotatedrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("plasterblock", 1));
            Result.Add(new InventoryItem("plasterblockcurverotated", 1));
        }
    }

    [NCAPIType]
    public class plasterblockcurverotated : DecorativeType
    {
        public plasterblockcurverotated() : base("plasterblock", "curverotated",
            Utilities.MultiCombine(Entry.ModIconDirectory, "plasterblockcurverotated.png"))
        {
            this.SideAll = "plasterblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class plasterblockcurverotatedXMinus : DecorativeTypeXMinus
    {
        public plasterblockcurverotatedXMinus() : base("plasterblock", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx-");
        }
    }

    [NCAPIType]
    public class plasterblockcurverotatedXPlus : DecorativeTypeXPlus
    {
        public plasterblockcurverotatedXPlus() : base("plasterblock", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx+");
        }
    }

    [NCAPIType]
    public class plasterblockcurverotatedZMinus : DecorativeTypeZMinus
    {
        public plasterblockcurverotatedZMinus() : base("plasterblock", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz-");
        }
    }

    [NCAPIType]
    public class plasterblockcurverotatedZPlus : DecorativeTypeZPlus
    {
        public plasterblockcurverotatedZPlus() : base("plasterblock", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz+");
        }
    }
}