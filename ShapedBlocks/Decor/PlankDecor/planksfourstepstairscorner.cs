using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class PlanksfourstepstairscornerRecipe : BaseRecipe
    {
        public PlanksfourstepstairscornerRecipe() : base("planksfourstepstairscornerrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("planks", 1));
            Result.Add(new InventoryItem("planksfourstepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class Planksfourstepstairscorner : DecorativeType
    {
        public Planksfourstepstairscorner() : base("planks", "fourstepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "planksfourstepstairscorner.png"))
        {
            this.SideAll = "planks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class planksfourstepstairscornerXMinus : DecorativeTypeXMinus
    {
        public planksfourstepstairscornerXMinus() : base("planks", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx-");
        }
    }

    [NCAPIType]
    public class planksfourstepstairscornerXPlus : DecorativeTypeXPlus
    {
        public planksfourstepstairscornerXPlus() : base("planks", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx+");
        }
    }

    [NCAPIType]
    public class planksfourstepstairscornerZMinus : DecorativeTypeZMinus
    {
        public planksfourstepstairscornerZMinus() : base("planks", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz-");
        }
    }

    [NCAPIType]
    public class planksfourstepstairscornerZPlus : DecorativeTypeZPlus
    {
        public planksfourstepstairscornerZPlus() : base("planks", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz+");
        }
    }
}