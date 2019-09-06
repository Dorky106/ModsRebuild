using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class plasterblockslopeinsidecornerRecipe : BaseRecipe
    {
        public plasterblockslopeinsidecornerRecipe() : base("plasterblockslopeinsidecornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("plasterblock", 1));
            Result.Add(new InventoryItem("plasterblockslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class plasterblockslopeinsidecorner : DecorativeType
    {
        public plasterblockslopeinsidecorner() : base("plasterblock", "slopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "plasterblockslopeinsidecorner.png"))
        {
            this.SideAll = "plasterblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class plasterblockslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public plasterblockslopeinsidecornerXMinus() : base("plasterblock", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class plasterblockslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public plasterblockslopeinsidecornerXPlus() : base("plasterblock", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class plasterblockslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public plasterblockslopeinsidecornerZMinus() : base("plasterblock", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class plasterblockslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public plasterblockslopeinsidecornerZPlus() : base("plasterblock", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz+");
        }
    }
}