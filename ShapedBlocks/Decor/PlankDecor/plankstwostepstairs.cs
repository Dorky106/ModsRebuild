using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class plankstwostepstairsRecipe : BaseRecipe
    {
        public plankstwostepstairsRecipe() : base("plankstwostepstairsrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("planks", 1));
            Result.Add(new InventoryItem("plankstwostepstairs", 1));
        }
    }

    [NCAPIType]
    public class plankstwostepstairs : DecorativeType
    {
        public plankstwostepstairs() : base("planks", "twostepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "plankstwostepstairs.png"))
        {
            this.SideAll = "planks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class plankstwostepstairsXMinus : DecorativeTypeXMinus
    {
        public plankstwostepstairsXMinus() : base("planks", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx-");
        }
    }

    [NCAPIType]
    public class plankstwostepstairsXPlus : DecorativeTypeXPlus
    {
        public plankstwostepstairsXPlus() : base("planks", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx+");
        }
    }

    [NCAPIType]
    public class plankstwostepstairsZMinus : DecorativeTypeZMinus
    {
        public plankstwostepstairsZMinus() : base("planks", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz-");
        }
    }

    [NCAPIType]
    public class plankstwostepstairsZPlus : DecorativeTypeZPlus
    {
        public plankstwostepstairsZPlus() : base("planks", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz+");
        }
    }
}