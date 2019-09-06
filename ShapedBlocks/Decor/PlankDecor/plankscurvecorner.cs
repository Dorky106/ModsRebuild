using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class PlankscurvecornerRecipe : BaseRecipe
    {
        public PlankscurvecornerRecipe() : base("plankscurvecornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("planks", 1));
            Result.Add(new InventoryItem("plankscurvecorner", 1));
        }
    }

    [NCAPIType]
    public class Plankscurvecorner : DecorativeType
    {
        public Plankscurvecorner() : base("planks", "curvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "plankscurvecorner.png"))
        {
            this.SideAll = "planks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class plankscurvecornerXMinus : DecorativeTypeXMinus
    {
        public plankscurvecornerXMinus() : base("planks", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx-");
        }
    }

    [NCAPIType]
    public class plankscurvecornerXPlus : DecorativeTypeXPlus
    {
        public plankscurvecornerXPlus() : base("planks", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx+");
        }
    }

    [NCAPIType]
    public class plankscurvecornerZMinus : DecorativeTypeZMinus
    {
        public plankscurvecornerZMinus() : base("planks", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz-");
        }
    }

    [NCAPIType]
    public class plankscurvecornerZPlus : DecorativeTypeZPlus
    {
        public plankscurvecornerZPlus() : base("planks", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz+");
        }
    }
}