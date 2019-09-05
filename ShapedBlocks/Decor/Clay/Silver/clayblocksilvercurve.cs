using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocksilvercurveRecipe : BaseRecipe
    {
        public clayblocksilvercurveRecipe() : base("clayblocksilvercurverecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocksilvercurve", 1));
        }
    }

    [NCAPIType]
    public class clayblocksilvercurve : DecorativeType
    {
        public clayblocksilvercurve() : base("clayblocksilver", "curve",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocksilvercurve.png"))
        {
            this.SideAll = "clayblocksilver";
        }
    }

    [NCAPIType]
    public class clayblocksilvercurveXMinus : DecorativeTypeXMinus
    {
        public clayblocksilvercurveXMinus() : base("clayblocksilver", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex-");
        }
    }

    [NCAPIType]
    public class clayblocksilvercurveXPlus : DecorativeTypeXPlus
    {
        public clayblocksilvercurveXPlus() : base("clayblocksilver", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvex+");
        }
    }

    [NCAPIType]
    public class clayblocksilvercurveZMinus : DecorativeTypeZMinus
    {
        public clayblocksilvercurveZMinus() : base("clayblocksilver", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez-");
        }
    }

    [NCAPIType]
    public class clayblocksilvercurveZPlus : DecorativeTypeZPlus
    {
        public clayblocksilvercurveZPlus() : base("clayblocksilver", "curve", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvez+");
        }
    }
}