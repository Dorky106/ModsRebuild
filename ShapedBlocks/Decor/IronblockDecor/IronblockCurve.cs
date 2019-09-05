using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class ironblockcurveRecipe : BaseRecipe
    {
        public ironblockcurveRecipe() : base("ironblockcurverecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("ironblock", 1));
            Result.Add(new InventoryItem("ironblockcurve", 1));
        }
    }

    [NCAPIType]
    public class ironblockcurve : DecorativeType
    {
        public ironblockcurve() : base("ironblock", "curve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "ironblockcurve.png"))
        {
            this.SideAll = "ironblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class ironblockcurveXMinus : DecorativeTypeXMinus
    {
        public ironblockcurveXMinus() : base("ironblock", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex-");
        }
    }

    [NCAPIType]
    public class ironblockcurveXPlus : DecorativeTypeXPlus
    {
        public ironblockcurveXPlus() : base("ironblock", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex+");
        }
    }

    [NCAPIType]
    public class ironblockcurveZMinus : DecorativeTypeZMinus
    {
        public ironblockcurveZMinus() : base("ironblock", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez-");
        }
    }

    [NCAPIType]
    public class ironblockcurveZPlus : DecorativeTypeZPlus
    {
        public ironblockcurveZPlus() : base("ironblock", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez+");
        }
    }
}