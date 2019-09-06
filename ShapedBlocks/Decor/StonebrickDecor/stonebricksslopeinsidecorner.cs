using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class stonebricksslopeinsidecornerRecipe : BaseRecipe
    {
        public stonebricksslopeinsidecornerRecipe() : base("stonebricksslopeinsidecornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("stonebricks", 1));
            Result.Add(new InventoryItem("stonebricksslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class stonebricksslopeinsidecorner : DecorativeType
    {
        public stonebricksslopeinsidecorner() : base("stonebricks", "slopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "stonebricksslopeinsidecorner.png"))
        {
            this.SideAll = "stonebricks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class stonebricksslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public stonebricksslopeinsidecornerXMinus() : base("stonebricks", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class stonebricksslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public stonebricksslopeinsidecornerXPlus() : base("stonebricks", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class stonebricksslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public stonebricksslopeinsidecornerZMinus() : base("stonebricks", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class stonebricksslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public stonebricksslopeinsidecornerZPlus() : base("stonebricks", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz+");
        }
    }
}