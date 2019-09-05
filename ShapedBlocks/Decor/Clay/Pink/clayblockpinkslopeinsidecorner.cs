using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpinkslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockpinkslopeinsidecornerRecipe() : base("clayblockpinkslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpinkslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockpinkslopeinsidecorner : DecorativeType
    {
        public clayblockpinkslopeinsidecorner() : base("clayblockpink", "slopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpinkslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockpink";
        }
    }

    [NCAPIType]
    public class clayblockpinkslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockpinkslopeinsidecornerXMinus() : base("clayblockpink", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockpinkslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockpinkslopeinsidecornerXPlus() : base("clayblockpink", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockpinkslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockpinkslopeinsidecornerZMinus() : base("clayblockpink", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockpinkslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockpinkslopeinsidecornerZPlus() : base("clayblockpink", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz+");
        }
    }
}