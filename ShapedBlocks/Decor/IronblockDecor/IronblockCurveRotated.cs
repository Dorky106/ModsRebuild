using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class IronblockcurverotatedRecipe : BaseRecipe
    {
        public IronblockcurverotatedRecipe() : base("ironblockcurverotatedrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("ironblock", 1));
            Result.Add(new InventoryItem("ironblockcurverotated", 1));
        }
    }

    [NCAPIType]
    public class Ironblockcurverotated : DecorativeType
    {
        public Ironblockcurverotated() : base("ironblock", "curverotated",
            Utilities.MultiCombine(Entry.ModIconDirectory, "ironblockcurverotated.png"))
        {
            this.SideAll = "ironblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class ironblockcurverotatedXMinus : DecorativeTypeXMinus
    {
        public ironblockcurverotatedXMinus() : base("ironblock", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx-");
        }
    }

    [NCAPIType]
    public class ironblockcurverotatedXPlus : DecorativeTypeXPlus
    {
        public ironblockcurverotatedXPlus() : base("ironblock", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx+");
        }
    }

    [NCAPIType]
    public class ironblockcurverotatedZMinus : DecorativeTypeZMinus
    {
        public ironblockcurverotatedZMinus() : base("ironblock", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz-");
        }
    }

    [NCAPIType]
    public class ironblockcurverotatedZPlus : DecorativeTypeZPlus
    {
        public ironblockcurverotatedZPlus() : base("ironblock", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz+");
        }
    }
}