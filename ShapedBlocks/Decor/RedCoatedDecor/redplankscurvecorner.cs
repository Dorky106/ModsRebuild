using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class redplankscurvecornerRecipe : BaseRecipe
    {
        public redplankscurvecornerRecipe() : base("redplankscurvecornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("redplanks", 1));
            Result.Add(new InventoryItem("redplankscurvecorner", 1));
        }
    }

    [NCAPIType]
    public class redplankscurvecorner : DecorativeType
    {
        public redplankscurvecorner() : base("redplanks", "curvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "redplankscurvecorner.png"))
        {
            this.SideAll = "redplanks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class redplankscurvecornerXMinus : DecorativeTypeXMinus
    {
        public redplankscurvecornerXMinus() : base("redplanks", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx-");
        }
    }

    [NCAPIType]
    public class redplankscurvecornerXPlus : DecorativeTypeXPlus
    {
        public redplankscurvecornerXPlus() : base("redplanks", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx+");
        }
    }

    [NCAPIType]
    public class redplankscurvecornerZMinus : DecorativeTypeZMinus
    {
        public redplankscurvecornerZMinus() : base("redplanks", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz-");
        }
    }

    [NCAPIType]
    public class redplankscurvecornerZPlus : DecorativeTypeZPlus
    {
        public redplankscurvecornerZPlus() : base("redplanks", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz+");
        }
    }
}