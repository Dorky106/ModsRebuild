using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockcyanslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockcyanslopeinsidecornerRecipe() : base("clayblockcyanslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockcyanslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockcyanslopeinsidecorner : DecorativeType
    {
        public clayblockcyanslopeinsidecorner() : base("clayblockcyan", "slopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockcyanslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockcyan";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockcyanslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockcyanslopeinsidecornerXMinus() : base("clayblockcyan", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockcyanslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockcyanslopeinsidecornerXPlus() : base("clayblockcyan", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockcyanslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockcyanslopeinsidecornerZMinus() : base("clayblockcyan", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockcyanslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockcyanslopeinsidecornerZPlus() : base("clayblockcyan", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz+");
        }
    }
}