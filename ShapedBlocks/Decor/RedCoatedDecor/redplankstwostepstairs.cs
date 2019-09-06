using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class redplankstwostepstairsRecipe : BaseRecipe
    {
        public redplankstwostepstairsRecipe() : base("redplankstwostepstairsrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("redplanks", 1));
            Result.Add(new InventoryItem("redplankstwostepstairs", 1));
        }
    }

    [NCAPIType]
    public class redplankstwostepstairs : DecorativeType
    {
        public redplankstwostepstairs() : base("redplanks", "twostepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "redplankstwostepstairs.png"))
        {
            this.SideAll = "redplanks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class redplankstwostepstairsXMinus : DecorativeTypeXMinus
    {
        public redplankstwostepstairsXMinus() : base("redplanks", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx-");
        }
    }

    [NCAPIType]
    public class redplankstwostepstairsXPlus : DecorativeTypeXPlus
    {
        public redplankstwostepstairsXPlus() : base("redplanks", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx+");
        }
    }

    [NCAPIType]
    public class redplankstwostepstairsZMinus : DecorativeTypeZMinus
    {
        public redplankstwostepstairsZMinus() : base("redplanks", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz-");
        }
    }

    [NCAPIType]
    public class redplankstwostepstairsZPlus : DecorativeTypeZPlus
    {
        public redplankstwostepstairsZPlus() : base("redplanks", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz+");
        }
    }
}