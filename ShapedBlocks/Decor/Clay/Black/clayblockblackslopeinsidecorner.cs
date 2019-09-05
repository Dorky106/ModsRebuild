using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblackslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblockblackslopeinsidecornerRecipe() : base("clayblockblackslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblackslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockblackslopeinsidecorner : DecorativeType
    {
        public clayblockblackslopeinsidecorner() : base("clayblockblack", "slopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblackslopeinsidecorner.png"))
        {
            this.SideAll = "clayblockblack";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblackslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockblackslopeinsidecornerXMinus() : base("clayblockblack", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockblackslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockblackslopeinsidecornerXPlus() : base("clayblockblack", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockblackslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockblackslopeinsidecornerZMinus() : base("clayblockblack", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockblackslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockblackslopeinsidecornerZPlus() : base("clayblockblack", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz+");
        }
    }
}