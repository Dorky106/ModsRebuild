using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class plasterblockslopecornerRecipe : BaseRecipe
    {
        public plasterblockslopecornerRecipe() : base("plasterblockslopecornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("plasterblock", 1));
            Result.Add(new InventoryItem("plasterblockslopecorner", 1));
        }
    }

    [NCAPIType]
    public class plasterblockslopecorner : DecorativeType
    {
        public plasterblockslopecorner() : base("plasterblock", "slopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "plasterblockslopecorner.png"))
        {
            this.SideAll = "plasterblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class plasterblockslopecornerXMinus : DecorativeTypeXMinus
    {
        public plasterblockslopecornerXMinus() : base("plasterblock", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx-");
        }
    }

    [NCAPIType]
    public class plasterblockslopecornerXPlus : DecorativeTypeXPlus
    {
        public plasterblockslopecornerXPlus() : base("plasterblock", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx+");
        }
    }

    [NCAPIType]
    public class plasterblockslopecornerZMinus : DecorativeTypeZMinus
    {
        public plasterblockslopecornerZMinus() : base("plasterblock", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz-");
        }
    }

    [NCAPIType]
    public class plasterblockslopecornerZPlus : DecorativeTypeZPlus
    {
        public plasterblockslopecornerZPlus() : base("plasterblock", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz+");
        }
    }
}