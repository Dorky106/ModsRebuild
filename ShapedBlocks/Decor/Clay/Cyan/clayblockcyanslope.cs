using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockcyanslopeRecipe : BaseRecipe
    {
        public clayblockcyanslopeRecipe() : base("clayblockcyansloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockcyanslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockcyanslope : DecorativeType
    {
        public clayblockcyanslope() : base("clayblockcyan", "slope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockcyanslope.png"))
        {
            this.SideAll = "clayblockcyan";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockcyanslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockcyanslopeXMinus() : base("clayblockcyan", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex-");
        }
    }

    [NCAPIType]
    public class clayblockcyanslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockcyanslopeXPlus() : base("clayblockcyan", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex+");
        }
    }

    [NCAPIType]
    public class clayblockcyanslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockcyanslopeZMinus() : base("clayblockcyan", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez-");
        }
    }

    [NCAPIType]
    public class clayblockcyanslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockcyanslopeZPlus() : base("clayblockcyan", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez+");
        }
    }
}