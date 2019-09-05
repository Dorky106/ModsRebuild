using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgreenupsidedowncurveRecipe : BaseRecipe
    {
        public clayblockgreenupsidedowncurveRecipe() : base("clayblockgreenupsidedowncurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgreenupsidedowncurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedowncurve : DecorativeType
    {
        public clayblockgreenupsidedowncurve() : base("clayblockgreen", "upsidedowncurve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgreenupsidedowncurve.png"))
        {
            this.SideAll = "clayblockgreen";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedowncurveXMinus : DecorativeTypeXMinus
    {
        public clayblockgreenupsidedowncurveXMinus() : base("clayblockgreen", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex-");
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedowncurveXPlus : DecorativeTypeXPlus
    {
        public clayblockgreenupsidedowncurveXPlus() : base("clayblockgreen", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex+");
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedowncurveZMinus : DecorativeTypeZMinus
    {
        public clayblockgreenupsidedowncurveZMinus() : base("clayblockgreen", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez-");
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedowncurveZPlus : DecorativeTypeZPlus
    {
        public clayblockgreenupsidedowncurveZPlus() : base("clayblockgreen", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez+");
        }
    }
}