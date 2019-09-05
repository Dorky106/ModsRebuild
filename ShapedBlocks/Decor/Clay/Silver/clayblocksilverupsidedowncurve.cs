using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocksilverupsidedowncurveRecipe : BaseRecipe
    {
        public clayblocksilverupsidedowncurveRecipe() : base("clayblocksilverupsidedowncurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocksilverupsidedowncurve", 1));
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedowncurve : DecorativeType
    {
        public clayblocksilverupsidedowncurve() : base("clayblocksilver", "upsidedowncurve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocksilverupsidedowncurve.png"))
        {
            this.SideAll = "clayblocksilver";
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedowncurveXMinus : DecorativeTypeXMinus
    {
        public clayblocksilverupsidedowncurveXMinus() : base("clayblocksilver", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex-");
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedowncurveXPlus : DecorativeTypeXPlus
    {
        public clayblocksilverupsidedowncurveXPlus() : base("clayblocksilver", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvex+");
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedowncurveZMinus : DecorativeTypeZMinus
    {
        public clayblocksilverupsidedowncurveZMinus() : base("clayblocksilver", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez-");
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedowncurveZPlus : DecorativeTypeZPlus
    {
        public clayblocksilverupsidedowncurveZPlus() : base("clayblocksilver", "upsidedowncurve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvez+");
        }
    }
}