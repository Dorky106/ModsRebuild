using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class PlanksslopecornerRecipe : BaseRecipe
    {
        public PlanksslopecornerRecipe() : base("planksslopecornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("planks", 1));
            Result.Add(new InventoryItem("planksslopecorner", 1));
        }
    }

    [NCAPIType]
    public class Planksslopecorner : DecorativeType
    {
        public Planksslopecorner() : base("planks", "slopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "planksslopecorner.png"))
        {
            this.SideAll = "planks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class planksslopecornerXMinus : DecorativeTypeXMinus
    {
        public planksslopecornerXMinus() : base("planks", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx-");
        }
    }

    [NCAPIType]
    public class planksslopecornerXPlus : DecorativeTypeXPlus
    {
        public planksslopecornerXPlus() : base("planks", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx+");
        }
    }

    [NCAPIType]
    public class planksslopecornerZMinus : DecorativeTypeZMinus
    {
        public planksslopecornerZMinus() : base("planks", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz-");
        }
    }

    [NCAPIType]
    public class planksslopecornerZPlus : DecorativeTypeZPlus
    {
        public planksslopecornerZPlus() : base("planks", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz+");
        }
    }
}