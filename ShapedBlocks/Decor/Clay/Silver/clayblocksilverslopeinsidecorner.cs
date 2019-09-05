using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocksilverslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblocksilverslopeinsidecornerRecipe() : base("clayblocksilverslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocksilverslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocksilverslopeinsidecorner : DecorativeType
    {
        public clayblocksilverslopeinsidecorner() : base("clayblocksilver", "slopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocksilverslopeinsidecorner.png"))
        {
            this.SideAll = "clayblocksilver";
        }
    }

    [NCAPIType]
    public class clayblocksilverslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblocksilverslopeinsidecornerXMinus() : base("clayblocksilver", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblocksilverslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblocksilverslopeinsidecornerXPlus() : base("clayblocksilver", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblocksilverslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblocksilverslopeinsidecornerZMinus() : base("clayblocksilver", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblocksilverslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblocksilverslopeinsidecornerZPlus() : base("clayblocksilver", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz+");
        }
    }
}