using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class stonebricksupsidedowncurveRecipe : BaseRecipe
    {
        public stonebricksupsidedowncurveRecipe() : base("stonebricksupsidedowncurverecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("stonebricks", 1));
            Result.Add(new InventoryItem("stonebricksupsidedowncurve", 1));
        }
    }

    [NCAPIType]
    public class stonebricksupsidedowncurve : DecorativeType
    {
        public stonebricksupsidedowncurve() : base("stonebricks", "upsidedowncurve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "stonebricksupsidedowncurve.png"))
        {
            this.SideAll = "stonebricks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class stonebricksupsidedowncurveXMinus : DecorativeTypeXMinus
    {
        public stonebricksupsidedowncurveXMinus() : base("stonebricks", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex-");
        }
    }

    [NCAPIType]
    public class stonebricksupsidedowncurveXPlus : DecorativeTypeXPlus
    {
        public stonebricksupsidedowncurveXPlus() : base("stonebricks", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex+");
        }
    }

    [NCAPIType]
    public class stonebricksupsidedowncurveZMinus : DecorativeTypeZMinus
    {
        public stonebricksupsidedowncurveZMinus() : base("stonebricks", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez-");
        }
    }

    [NCAPIType]
    public class stonebricksupsidedowncurveZPlus : DecorativeTypeZPlus
    {
        public stonebricksupsidedowncurveZPlus() : base("stonebricks", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez+");
        }
    }
}