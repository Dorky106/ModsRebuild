using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockcyanslopecornerRecipe : BaseRecipe
    {
        public clayblockcyanslopecornerRecipe() : base("clayblockcyanslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockcyanslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockcyanslopecorner : DecorativeType
    {
        public clayblockcyanslopecorner() : base("clayblockcyan", "slopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockcyanslopecorner.png"))
        {
            this.SideAll = "clayblockcyan";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockcyanslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockcyanslopecornerXMinus() : base("clayblockcyan", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockcyanslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockcyanslopecornerXPlus() : base("clayblockcyan", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockcyanslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockcyanslopecornerZMinus() : base("clayblockcyan", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockcyanslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockcyanslopecornerZPlus() : base("clayblockcyan", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz+");
        }
    }
}