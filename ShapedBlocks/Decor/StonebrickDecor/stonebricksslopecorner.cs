using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class stonebricksslopecornerRecipe : BaseRecipe
    {
        public stonebricksslopecornerRecipe() : base("stonebricksslopecornerrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("stonebricks", 1));
            Result.Add(new InventoryItem("stonebricksslopecorner", 1));
        }
    }

    [NCAPIType]
    public class stonebricksslopecorner : DecorativeType
    {
        public stonebricksslopecorner() : base("stonebricks", "slopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "stonebricksslopecorner.png"))
        {
            this.SideAll = "stonebricks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class stonebricksslopecornerXMinus : DecorativeTypeXMinus
    {
        public stonebricksslopecornerXMinus() : base("stonebricks", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx-");
        }
    }

    [NCAPIType]
    public class stonebricksslopecornerXPlus : DecorativeTypeXPlus
    {
        public stonebricksslopecornerXPlus() : base("stonebricks", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx+");
        }
    }

    [NCAPIType]
    public class stonebricksslopecornerZMinus : DecorativeTypeZMinus
    {
        public stonebricksslopecornerZMinus() : base("stonebricks", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz-");
        }
    }

    [NCAPIType]
    public class stonebricksslopecornerZPlus : DecorativeTypeZPlus
    {
        public stonebricksslopecornerZPlus() : base("stonebricks", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz+");
        }
    }
}