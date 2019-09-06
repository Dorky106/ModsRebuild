using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class PlanksupsidedownslopeinsidecornerRecipe : BaseRecipe
    {
        public PlanksupsidedownslopeinsidecornerRecipe() : base("planksupsidedownslopeinsidecornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("planks", 1));
            Result.Add(new InventoryItem("planksupsidedownslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class Planksupsidedownslopeinsidecorner : DecorativeType
    {
        public Planksupsidedownslopeinsidecorner() : base("planks", "upsidedownslopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "planksupsidedownslopeinsidecorner.png"))
        {
            this.SideAll = "planks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class PlanksupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public PlanksupsidedownslopeinsidecornerXMinus() : base("planks", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class planksupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public planksupsidedownslopeinsidecornerXPlus() : base("planks", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class planksupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public planksupsidedownslopeinsidecornerZMinus() : base("planks", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class planksupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public planksupsidedownslopeinsidecornerZPlus() : base("planks", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz+");
        }
    }
}