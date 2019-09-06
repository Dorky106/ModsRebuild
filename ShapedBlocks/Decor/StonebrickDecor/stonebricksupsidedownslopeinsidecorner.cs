using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class stonebricksupsidedownslopeinsidecornerRecipe : BaseRecipe
    {
        public stonebricksupsidedownslopeinsidecornerRecipe() : base("stonebricksupsidedownslopeinsidecornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("stonebricks", 1));
            Result.Add(new InventoryItem("stonebricksupsidedownslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class stonebricksupsidedownslopeinsidecorner : DecorativeType
    {
        public stonebricksupsidedownslopeinsidecorner() : base("stonebricks", "upsidedownslopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "stonebricksupsidedownslopeinsidecorner.png"))
        {
            this.SideAll = "stonebricks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class stonebricksupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public stonebricksupsidedownslopeinsidecornerXMinus() : base("stonebricks", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class stonebricksupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public stonebricksupsidedownslopeinsidecornerXPlus() : base("stonebricks", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class stonebricksupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public stonebricksupsidedownslopeinsidecornerZMinus() : base("stonebricks", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class stonebricksupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public stonebricksupsidedownslopeinsidecornerZPlus() : base("stonebricks", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz+");
        }
    }
}