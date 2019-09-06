using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class plasterblockupsidedowncurveRecipe : BaseRecipe
    {
        public plasterblockupsidedowncurveRecipe() : base("plasterblockupsidedowncurverecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("plasterblock", 1));
            Result.Add(new InventoryItem("plasterblockupsidedowncurve", 1));
        }
    }

    [NCAPIType]
    public class plasterblockupsidedowncurve : DecorativeType
    {
        public plasterblockupsidedowncurve() : base("plasterblock", "upsidedowncurve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "plasterblockupsidedowncurve.png"))
        {
            this.SideAll = "plasterblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class plasterblockupsidedowncurveXMinus : DecorativeTypeXMinus
    {
        public plasterblockupsidedowncurveXMinus() : base("plasterblock", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex-");
        }
    }

    [NCAPIType]
    public class plasterblockupsidedowncurveXPlus : DecorativeTypeXPlus
    {
        public plasterblockupsidedowncurveXPlus() : base("plasterblock", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex+");
        }
    }

    [NCAPIType]
    public class plasterblockupsidedowncurveZMinus : DecorativeTypeZMinus
    {
        public plasterblockupsidedowncurveZMinus() : base("plasterblock", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez-");
        }
    }

    [NCAPIType]
    public class plasterblockupsidedowncurveZPlus : DecorativeTypeZPlus
    {
        public plasterblockupsidedowncurveZPlus() : base("plasterblock", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez+");
        }
    }
}