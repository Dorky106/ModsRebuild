using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklightblueslopecorneredgeRecipe : BaseRecipe
    {
        public clayblocklightblueslopecorneredgeRecipe() : base("clayblocklightblueslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklightblueslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblocklightblueslopecorneredge : DecorativeType
    {
        public clayblocklightblueslopecorneredge() : base("clayblocklightblue", "slopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklightblueslopecorneredge.png"))
        {
            this.SideAll = "clayblocklightblue";
        }
    }

    [NCAPIType]
    public class clayblocklightblueslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblocklightblueslopecorneredgeXMinus() : base("clayblocklightblue", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblocklightblueslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblocklightblueslopecorneredgeXPlus() : base("clayblocklightblue", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblocklightblueslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblocklightblueslopecorneredgeZMinus() : base("clayblocklightblue", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblocklightblueslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblocklightblueslopecorneredgeZPlus() : base("clayblocklightblue", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez+");
        }
    }
}