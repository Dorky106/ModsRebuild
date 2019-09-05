using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklightblueslopeRecipe : BaseRecipe
    {
        public clayblocklightblueslopeRecipe() : base("clayblocklightbluesloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklightblueslope", 1));
        }
    }

    [NCAPIType]
    public class clayblocklightblueslope : DecorativeType
    {
        public clayblocklightblueslope() : base("clayblocklightblue", "slope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklightblueslope.png"))
        {
            this.SideAll = "clayblocklightblue";
        }
    }

    [NCAPIType]
    public class clayblocklightblueslopeXMinus : DecorativeTypeXMinus
    {
        public clayblocklightblueslopeXMinus() : base("clayblocklightblue", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex-");
        }
    }

    [NCAPIType]
    public class clayblocklightblueslopeXPlus : DecorativeTypeXPlus
    {
        public clayblocklightblueslopeXPlus() : base("clayblocklightblue", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex+");
        }
    }

    [NCAPIType]
    public class clayblocklightblueslopeZMinus : DecorativeTypeZMinus
    {
        public clayblocklightblueslopeZMinus() : base("clayblocklightblue", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez-");
        }
    }

    [NCAPIType]
    public class clayblocklightblueslopeZPlus : DecorativeTypeZPlus
    {
        public clayblocklightblueslopeZPlus() : base("clayblocklightblue", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez+");
        }
    }
}