using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class stonebricksupsidedownslopecornerRecipe : BaseRecipe
    {
        public stonebricksupsidedownslopecornerRecipe() : base("stonebricksupsidedownslopecornerrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("stonebricks", 1));
            Result.Add(new InventoryItem("stonebricksupsidedownslopecorner", 1));
        }
    }

    [NCAPIType]
    public class stonebricksupsidedownslopecorner : DecorativeType
    {
        public stonebricksupsidedownslopecorner() : base("stonebricks", "upsidedownslopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "stonebricksupsidedownslopecorner.png"))
        {
            this.SideAll = "stonebricks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class stonebricksupsidedownslopecornerXMinus : DecorativeTypeXMinus
    {
        public stonebricksupsidedownslopecornerXMinus() : base("stonebricks", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx-");
        }
    }

    [NCAPIType]
    public class stonebricksupsidedownslopecornerXPlus : DecorativeTypeXPlus
    {
        public stonebricksupsidedownslopecornerXPlus() : base("stonebricks", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx+");
        }
    }

    [NCAPIType]
    public class stonebricksupsidedownslopecornerZMinus : DecorativeTypeZMinus
    {
        public stonebricksupsidedownslopecornerZMinus() : base("stonebricks", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz-");
        }
    }

    [NCAPIType]
    public class stonebricksupsidedownslopecornerZPlus : DecorativeTypeZPlus
    {
        public stonebricksupsidedownslopecornerZPlus() : base("stonebricks", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz+");
        }
    }
}