using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class PlanksfourstepstairsinsidecornerRecipe : BaseRecipe
    {
        public PlanksfourstepstairsinsidecornerRecipe() : base("planksfourstepstairsinsidecornerrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("planks", 1));
            Result.Add(new InventoryItem("planksfourstepstairsinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class Planksfourstepstairsinsidecorner : DecorativeType
    {
        public Planksfourstepstairsinsidecorner() : base("planks", "fourstepstairsinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "planksfourstepstairsinsidecorner.png"))
        {
            this.SideAll = "planks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class planksfourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
    {
        public planksfourstepstairsinsidecornerXMinus() : base("planks", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx-");
        }
    }

    [NCAPIType]
    public class planksfourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
    {
        public planksfourstepstairsinsidecornerXPlus() : base("planks", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx+");
        }
    }

    [NCAPIType]
    public class planksfourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
    {
        public planksfourstepstairsinsidecornerZMinus() : base("planks", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz-");
        }
    }

    [NCAPIType]
    public class planksfourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
    {
        public planksfourstepstairsinsidecornerZPlus() : base("planks", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz+");
        }
    }
}