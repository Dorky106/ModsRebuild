using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklightbluecurverotatedRecipe : BaseRecipe
    {
        public clayblocklightbluecurverotatedRecipe() : base("clayblocklightbluecurverotatedrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklightbluecurverotated", 1));
        }
    }

    [NCAPIType]
    public class clayblocklightbluecurverotated : DecorativeType
    {
        public clayblocklightbluecurverotated() : base("clayblocklightblue", "curverotated",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklightbluecurverotated.png"))
        {
            this.SideAll = "clayblocklightblue";
        }
    }

    [NCAPIType]
    public class clayblocklightbluecurverotatedXMinus : DecorativeTypeXMinus
    {
        public clayblocklightbluecurverotatedXMinus() : base("clayblocklightblue", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx-");
        }
    }

    [NCAPIType]
    public class clayblocklightbluecurverotatedXPlus : DecorativeTypeXPlus
    {
        public clayblocklightbluecurverotatedXPlus() : base("clayblocklightblue", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedx+");
        }
    }

    [NCAPIType]
    public class clayblocklightbluecurverotatedZMinus : DecorativeTypeZMinus
    {
        public clayblocklightbluecurverotatedZMinus() : base("clayblocklightblue", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz-");
        }
    }

    [NCAPIType]
    public class clayblocklightbluecurverotatedZPlus : DecorativeTypeZPlus
    {
        public clayblocklightbluecurverotatedZPlus() : base("clayblocklightblue", "curverotated", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curverotatedz+");
        }
    }
}