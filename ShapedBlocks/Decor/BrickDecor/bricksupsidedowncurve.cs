using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class BricksupsidedowncurveRecipe : BaseRecipe
    {
        public BricksupsidedowncurveRecipe() : base("bricksupsidedowncurverecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("bricks", 1));
            Result.Add(new InventoryItem("bricksupsidedowncurve", 1));
        }
    }

    [NCAPIType]
    public class bricksupsidedowncurve : DecorativeType
    {
        public bricksupsidedowncurve() : base("bricks", "upsidedowncurve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "bricksupsidedowncurve.png"))
        {
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
            this.SideAll = "bricks";
        }
    }

    [NCAPIType]
    public class bricksupsidedowncurveXMinus : DecorativeTypeXMinus
    {
        public bricksupsidedowncurveXMinus() : base("bricks", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex-");
        }
    }

    [NCAPIType]
    public class bricksupsidedowncurveXPlus : DecorativeTypeXPlus
    {
        public bricksupsidedowncurveXPlus() : base("bricks", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex+");
        }
    }

    [NCAPIType]
    public class bricksupsidedowncurveZMinus : DecorativeTypeZMinus
    {
        public bricksupsidedowncurveZMinus() : base("bricks", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez-");
        }
    }

    [NCAPIType]
    public class bricksupsidedowncurveZPlus : DecorativeTypeZPlus
    {
        public bricksupsidedowncurveZPlus() : base("bricks", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez+");
        }
    }
}