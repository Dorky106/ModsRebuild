using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class stonebrickscurvecornerRecipe : BaseRecipe
    {
        public stonebrickscurvecornerRecipe() : base("stonebrickscurvecornerrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("stonebricks", 1));
            Result.Add(new InventoryItem("stonebrickscurvecorner", 1));
        }
    }

    [NCAPIType]
    public class stonebrickscurvecorner : DecorativeType
    {
        public stonebrickscurvecorner() : base("stonebricks", "curvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "stonebrickscurvecorner.png"))
        {
            this.SideAll = "stonebricks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class stonebrickscurvecornerXMinus : DecorativeTypeXMinus
    {
        public stonebrickscurvecornerXMinus() : base("stonebricks", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx-");
        }
    }

    [NCAPIType]
    public class stonebrickscurvecornerXPlus : DecorativeTypeXPlus
    {
        public stonebrickscurvecornerXPlus() : base("stonebricks", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx+");
        }
    }

    [NCAPIType]
    public class stonebrickscurvecornerZMinus : DecorativeTypeZMinus
    {
        public stonebrickscurvecornerZMinus() : base("stonebricks", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz-");
        }
    }

    [NCAPIType]
    public class stonebrickscurvecornerZPlus : DecorativeTypeZPlus
    {
        public stonebrickscurvecornerZPlus() : base("stonebricks", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz+");
        }
    }
}