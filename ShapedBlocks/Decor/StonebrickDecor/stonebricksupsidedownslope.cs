using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class stonebricksupsidedownslopeRecipe : BaseRecipe
    {
        public stonebricksupsidedownslopeRecipe() : base("stonebricksupsidedownsloperecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("stonebricks", 1));
            Result.Add(new InventoryItem("stonebricksupsidedownslope", 1));
        }
    }

    [NCAPIType]
    public class stonebricksupsidedownslope : DecorativeType
    {
        public stonebricksupsidedownslope() : base("stonebricks", "upsidedownslope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "stonebricksupsidedownslope.png"))
        {
            this.SideAll = "stonebricks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class stonebricksupsidedownslopeXMinus : DecorativeTypeXMinus
    {
        public stonebricksupsidedownslopeXMinus() : base("stonebricks", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex-");
        }
    }

    [NCAPIType]
    public class stonebricksupsidedownslopeXPlus : DecorativeTypeXPlus
    {
        public stonebricksupsidedownslopeXPlus() : base("stonebricks", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex+");
        }
    }

    [NCAPIType]
    public class stonebricksupsidedownslopeZMinus : DecorativeTypeZMinus
    {
        public stonebricksupsidedownslopeZMinus() : base("stonebricks", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez-");
        }
    }

    [NCAPIType]
    public class stonebricksupsidedownslopeZPlus : DecorativeTypeZPlus
    {
        public stonebricksupsidedownslopeZPlus() : base("stonebricks", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez+");
        }
    }
}