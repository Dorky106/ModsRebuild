using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class PlanksfourstepstairsRecipe : BaseRecipe
    {
        public PlanksfourstepstairsRecipe() : base("planksfourstepstairsrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("planks", 1));
            Result.Add(new InventoryItem("planksfourstepstairs", 1));
        }
    }

    [NCAPIType]
    public class Planksfourstepstairs : DecorativeType
    {
        public Planksfourstepstairs() : base("planks", "fourstepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "planksfourstepstairs.png"))
        {
            this.SideAll = "planks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class planksfourstepstairsXMinus : DecorativeTypeXMinus
    {
        public planksfourstepstairsXMinus() : base("planks", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class planksfourstepstairsXPlus : DecorativeTypeXPlus
    {
        public planksfourstepstairsXPlus() : base("planks", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class planksfourstepstairsZMinus : DecorativeTypeZMinus
    {
        public planksfourstepstairsZMinus() : base("planks", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class planksfourstepstairsZPlus : DecorativeTypeZPlus
    {
        public planksfourstepstairsZPlus() : base("planks", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}