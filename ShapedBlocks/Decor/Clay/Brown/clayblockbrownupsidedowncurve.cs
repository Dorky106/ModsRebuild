using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbrownupsidedowncurveRecipe : BaseRecipe
    {
        public clayblockbrownupsidedowncurveRecipe() : base("clayblockbrownupsidedowncurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbrownupsidedowncurve", 1));
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedowncurve : DecorativeType
    {
        public clayblockbrownupsidedowncurve() : base("clayblockbrown", "upsidedowncurve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbrownupsidedowncurve.png"))
        {
            this.SideAll = "clayblockbrown";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedowncurveXMinus : DecorativeTypeXMinus
    {
        public clayblockbrownupsidedowncurveXMinus() : base("clayblockbrown", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex-");
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedowncurveXPlus : DecorativeTypeXPlus
    {
        public clayblockbrownupsidedowncurveXPlus() : base("clayblockbrown", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex+");
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedowncurveZMinus : DecorativeTypeZMinus
    {
        public clayblockbrownupsidedowncurveZMinus() : base("clayblockbrown", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez-");
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedowncurveZPlus : DecorativeTypeZPlus
    {
        public clayblockbrownupsidedowncurveZPlus() : base("clayblockbrown", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez+");
        }
    }
}