using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockcyanslopecorneredgeRecipe : BaseRecipe
    {
        public clayblockcyanslopecorneredgeRecipe() : base("clayblockcyanslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockcyanslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblockcyanslopecorneredge : DecorativeType
    {
        public clayblockcyanslopecorneredge() : base("clayblockcyan", "slopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockcyanslopecorneredge.png"))
        {
            this.SideAll = "clayblockcyan";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockcyanslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockcyanslopecorneredgeXMinus() : base("clayblockcyan", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockcyanslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockcyanslopecorneredgeXPlus() : base("clayblockcyan", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockcyanslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockcyanslopecorneredgeZMinus() : base("clayblockcyan", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockcyanslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockcyanslopecorneredgeZPlus() : base("clayblockcyan", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez+");
        }
    }
}