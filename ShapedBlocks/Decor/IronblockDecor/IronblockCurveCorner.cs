using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class ironblockcurvecornerRecipe : BaseRecipe
    {
        public ironblockcurvecornerRecipe() : base("ironblockcurvecornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("ironblock", 1));
            Result.Add(new InventoryItem("ironblockcurvecorner", 1));
        }
    }

    [NCAPIType]
    public class ironblockcurvecorner : DecorativeType
    {
        public ironblockcurvecorner() : base("ironblock", "curvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "ironblockcurvecorner.png"))
        {
            this.SideAll = "ironblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class ironblockcurvecornerXMinus : DecorativeTypeXMinus
    {
        public ironblockcurvecornerXMinus() : base("ironblock", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx-");
        }
    }

    [NCAPIType]
    public class ironblockcurvecornerXPlus : DecorativeTypeXPlus
    {
        public ironblockcurvecornerXPlus() : base("ironblock", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx+");
        }
    }

    [NCAPIType]
    public class ironblockcurvecornerZMinus : DecorativeTypeZMinus
    {
        public ironblockcurvecornerZMinus() : base("ironblock", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz-");
        }
    }

    [NCAPIType]
    public class ironblockcurvecornerZPlus : DecorativeTypeZPlus
    {
        public ironblockcurvecornerZPlus() : base("ironblock", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz+");
        }
    }
}