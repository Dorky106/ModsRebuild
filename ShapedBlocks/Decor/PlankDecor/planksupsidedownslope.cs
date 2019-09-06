using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class planksupsidedownslopeRecipe : BaseRecipe
    {
        public planksupsidedownslopeRecipe() : base("planksupsidedownsloperecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("planks", 1));
            Result.Add(new InventoryItem("planksupsidedownslope", 1));
        }
    }

    [NCAPIType]
    public class planksupsidedownslope : DecorativeType
    {
        public planksupsidedownslope() : base("planks", "upsidedownslope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "planksupsidedownslope.png"))
        {
            this.SideAll = "planks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class planksupsidedownslopeXMinus : DecorativeTypeXMinus
    {
        public planksupsidedownslopeXMinus() : base("planks", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex-");
        }
    }

    [NCAPIType]
    public class planksupsidedownslopeXPlus : DecorativeTypeXPlus
    {
        public planksupsidedownslopeXPlus() : base("planks", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex+");
        }
    }

    [NCAPIType]
    public class planksupsidedownslopeZMinus : DecorativeTypeZMinus
    {
        public planksupsidedownslopeZMinus() : base("planks", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez-");
        }
    }

    [NCAPIType]
    public class planksupsidedownslopeZPlus : DecorativeTypeZPlus
    {
        public planksupsidedownslopeZPlus() : base("planks", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez+");
        }
    }
}