using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class stonebricksslopeRecipe : BaseRecipe
    {
        public stonebricksslopeRecipe() : base("stonebrickssloperecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("stonebricks", 1));
            Result.Add(new InventoryItem("stonebricksslope", 1));
        }
    }

    [NCAPIType]
    public class stonebricksslope : DecorativeType
    {
        public stonebricksslope() : base("stonebricks", "slope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "stonebricksslope.png"))
        {
            this.SideAll = "stonebricks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class stonebricksslopeXMinus : DecorativeTypeXMinus
    {
        public stonebricksslopeXMinus() : base("stonebricks", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class stonebricksslopeXPlus : DecorativeTypeXPlus
    {
        public stonebricksslopeXPlus() : base("stonebricks", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class stonebricksslopeZMinus : DecorativeTypeZMinus
    {
        public stonebricksslopeZMinus() : base("stonebricks", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class stonebricksslopeZPlus : DecorativeTypeZPlus
    {
        public stonebricksslopeZPlus() : base("stonebricks", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}