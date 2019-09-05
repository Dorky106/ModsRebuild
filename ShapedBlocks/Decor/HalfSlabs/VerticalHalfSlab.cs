using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor.HalfSlabs
{
    [NCAPIRecipe]
    public class VerticalHalfSlabRecipe : BaseRecipe
    {
        public VerticalHalfSlabRecipe() : base("plankshalfslaberecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("planks", 1));
            Result.Add(new InventoryItem("plankshalfslab", 1));
        }
    }

    [NCAPIType]
    public class VerticalHalfSlab : DecorativeType
    {
        public VerticalHalfSlab() : base("planks", "halfslab", "")
        {
            this.SideAll = "planks";
            this.Icon = "halfslab.png";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class IronblockCurveXMinus : DecorativeTypeXMinus
    {
        public IronblockCurveXMinus() : base("planks", "halfslab", Entry.ModName)
        {
        }
    }

    [NCAPIType]
    public class IronblockCurveXPlus : DecorativeTypeXPlus
    {
        public IronblockCurveXPlus() : base("planks", "halfslab", Entry.ModName)
        {
        }
    }

    [NCAPIType]
    public class IronblockCurveZMinus : DecorativeTypeZMinus
    {
        public IronblockCurveZMinus() : base("planks", "halfslab", Entry.ModName)
        {
        }
    }

    [NCAPIType]
    public class IronblockCurveZPlus : DecorativeTypeZPlus
    {
        public IronblockCurveZPlus() : base("planks", "halfslab", Entry.ModName)
        {
        }
    }
}