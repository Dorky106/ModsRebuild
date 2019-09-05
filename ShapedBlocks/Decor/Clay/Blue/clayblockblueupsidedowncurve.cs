using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblueupsidedowncurveRecipe : BaseRecipe
    {
        public clayblockblueupsidedowncurveRecipe() : base("clayblockblueupsidedowncurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblueupsidedowncurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedowncurve : DecorativeType
    {
        public clayblockblueupsidedowncurve() : base("clayblockblue", "upsidedowncurve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblueupsidedowncurve.png"))
        {
            this.SideAll = "clayblockblue";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedowncurveXMinus : DecorativeTypeXMinus
    {
        public clayblockblueupsidedowncurveXMinus() : base("clayblockblue", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex-");
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedowncurveXPlus : DecorativeTypeXPlus
    {
        public clayblockblueupsidedowncurveXPlus() : base("clayblockblue", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex+");
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedowncurveZMinus : DecorativeTypeZMinus
    {
        public clayblockblueupsidedowncurveZMinus() : base("clayblockblue", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez-");
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedowncurveZPlus : DecorativeTypeZPlus
    {
        public clayblockblueupsidedowncurveZPlus() : base("clayblockblue", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez+");
        }
    }
}