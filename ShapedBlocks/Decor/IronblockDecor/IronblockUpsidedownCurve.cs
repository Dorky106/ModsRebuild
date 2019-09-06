using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class IronblockupsidedowncurveRecipe : BaseRecipe
    {
        public IronblockupsidedowncurveRecipe() : base("ironblockupsidedowncurverecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("ironblock", 1));
            Result.Add(new InventoryItem("ironblockupsidedowncurve", 1));
        }
    }

    [NCAPIType]
    public class Ironblockupsidedowncurve : DecorativeType
    {
        public Ironblockupsidedowncurve() : base("ironblock", "upsidedowncurve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "ironblockupsidedowncurve.png"))
        {
            this.SideAll = "ironblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class ironblockupsidedowncurveXMinus : DecorativeTypeXMinus
    {
        public ironblockupsidedowncurveXMinus() : base("ironblock", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex-");
        }
    }

    [NCAPIType]
    public class ironblockupsidedowncurveXPlus : DecorativeTypeXPlus
    {
        public ironblockupsidedowncurveXPlus() : base("ironblock", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex+");
        }
    }

    [NCAPIType]
    public class ironblockupsidedowncurveZMinus : DecorativeTypeZMinus
    {
        public ironblockupsidedowncurveZMinus() : base("ironblock", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez-");
        }
    }

    [NCAPIType]
    public class ironblockupsidedowncurveZPlus : DecorativeTypeZPlus
    {
        public ironblockupsidedowncurveZPlus() : base("ironblock", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez+");
        }
    }
}