using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class planksupsidedownslopecornerRecipe : BaseRecipe
    {
        public planksupsidedownslopecornerRecipe() : base("planksupsidedownslopecornerrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("planks", 1));
            Result.Add(new InventoryItem("planksupsidedownslopecorner", 1));
        }
    }

    [NCAPIType]
    public class planksupsidedownslopecorner : DecorativeType
    {
        public planksupsidedownslopecorner() : base("planks", "upsidedownslopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "planksupsidedownslopecorner.png"))
        {
            this.SideAll = "planks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class planksupsidedownslopecornerXMinus : DecorativeTypeXMinus
    {
        public planksupsidedownslopecornerXMinus() : base("planks", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx-");
        }
    }

    [NCAPIType]
    public class planksupsidedownslopecornerXPlus : DecorativeTypeXPlus
    {
        public planksupsidedownslopecornerXPlus() : base("planks", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx+");
        }
    }

    [NCAPIType]
    public class planksupsidedownslopecornerZMinus : DecorativeTypeZMinus
    {
        public planksupsidedownslopecornerZMinus() : base("planks", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz-");
        }
    }

    [NCAPIType]
    public class planksupsidedownslopecornerZPlus : DecorativeTypeZPlus
    {
        public planksupsidedownslopecornerZPlus() : base("planks", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz+");
        }
    }
}