using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class PlanksslopeRecipe : BaseRecipe
    {
        public PlanksslopeRecipe() : base("plankssloperecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("planks", 1));
            Result.Add(new InventoryItem("planksslope", 1));
        }
    }

    [NCAPIType]
    public class Planksslope : DecorativeType
    {
        public Planksslope() : base("planks", "slope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "planksslope.png"))
        {
            this.SideAll = "planks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class planksslopeXMinus : DecorativeTypeXMinus
    {
        public planksslopeXMinus() : base("planks", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex-");
        }
    }

    [NCAPIType]
    public class planksslopeXPlus : DecorativeTypeXPlus
    {
        public planksslopeXPlus() : base("planks", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex+");
        }
    }

    [NCAPIType]
    public class planksslopeZMinus : DecorativeTypeZMinus
    {
        public planksslopeZMinus() : base("planks", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez-");
        }
    }

    [NCAPIType]
    public class planksslopeZPlus : DecorativeTypeZPlus
    {
        public planksslopeZPlus() : base("planks", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez+");
        }
    }
}