using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class plasterblockcurvecornerRecipe : BaseRecipe
    {
        public plasterblockcurvecornerRecipe() : base("plasterblockcurvecornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("plasterblock", 1));
            Result.Add(new InventoryItem("plasterblockcurvecorner", 1));
        }
    }

    [NCAPIType]
    public class plasterblockcurvecorner : DecorativeType
    {
        public plasterblockcurvecorner() : base("plasterblock", "curvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "plasterblockcurvecorner.png"))
        {
            this.SideAll = "plasterblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class plasterblockcurvecornerXMinus : DecorativeTypeXMinus
    {
        public plasterblockcurvecornerXMinus() : base("plasterblock", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx-");
        }
    }

    [NCAPIType]
    public class plasterblockcurvecornerXPlus : DecorativeTypeXPlus
    {
        public plasterblockcurvecornerXPlus() : base("plasterblock", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx+");
        }
    }

    [NCAPIType]
    public class plasterblockcurvecornerZMinus : DecorativeTypeZMinus
    {
        public plasterblockcurvecornerZMinus() : base("plasterblock", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz-");
        }
    }

    [NCAPIType]
    public class plasterblockcurvecornerZPlus : DecorativeTypeZPlus
    {
        public plasterblockcurvecornerZPlus() : base("plasterblock", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz+");
        }
    }
}