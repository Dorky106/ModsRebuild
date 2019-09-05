using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class plasterblockcurveRecipe : BaseRecipe
    {
        public plasterblockcurveRecipe() : base("plasterblockcurverecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("plasterblock", 1));
            Result.Add(new InventoryItem("plasterblockcurve", 1));
        }
    }

    [NCAPIType]
    public class plasterblockcurve : DecorativeType
    {
        public plasterblockcurve() : base("plasterblock", "curve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "plasterblockcurve.png"))
        {
            this.SideAll = "plasterblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class plasterblockcurveXMinus : DecorativeTypeXMinus
    {
        public plasterblockcurveXMinus() : base("plasterblock", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex-");
        }
    }

    [NCAPIType]
    public class plasterblockcurveXPlus : DecorativeTypeXPlus
    {
        public plasterblockcurveXPlus() : base("plasterblock", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex+");
        }
    }

    [NCAPIType]
    public class plasterblockcurveZMinus : DecorativeTypeZMinus
    {
        public plasterblockcurveZMinus() : base("plasterblock", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez-");
        }
    }

    [NCAPIType]
    public class plasterblockcurveZPlus : DecorativeTypeZPlus
    {
        public plasterblockcurveZPlus() : base("plasterblock", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez+");
        }
    }
}