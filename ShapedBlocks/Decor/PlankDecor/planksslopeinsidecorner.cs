using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class PlanksslopeinsidecornerRecipe : BaseRecipe
    {
        public PlanksslopeinsidecornerRecipe() : base("planksslopeinsidecornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("planks", 1));
            Result.Add(new InventoryItem("planksslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class Planksslopeinsidecorner : DecorativeType
    {
        public Planksslopeinsidecorner() : base("planks", "slopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "planksslopeinsidecorner.png"))
        {
            this.SideAll = "planks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class planksslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public planksslopeinsidecornerXMinus() : base("planks", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class planksslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public planksslopeinsidecornerXPlus() : base("planks", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class planksslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public planksslopeinsidecornerZMinus() : base("planks", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class planksslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public planksslopeinsidecornerZPlus() : base("planks", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz+");
        }
    }
}