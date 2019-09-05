using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class plasterblockupsidedownslopeinsidecornerRecipe : BaseRecipe
    {
        public plasterblockupsidedownslopeinsidecornerRecipe() : base("plasterblockupsidedownslopeinsidecornerrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("plasterblock", 1));
            Result.Add(new InventoryItem("plasterblockupsidedownslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class plasterblockupsidedownslopeinsidecorner : DecorativeType
    {
        public plasterblockupsidedownslopeinsidecorner() : base("plasterblock", "upsidedownslopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "plasterblockupsidedownslopeinsidecorner.png"))
        {
            this.SideAll = "plasterblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class plasterblockupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public plasterblockupsidedownslopeinsidecornerXMinus() : base("plasterblock", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class plasterblockupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public plasterblockupsidedownslopeinsidecornerXPlus() : base("plasterblock", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class plasterblockupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public plasterblockupsidedownslopeinsidecornerZMinus() : base("plasterblock", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class plasterblockupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public plasterblockupsidedownslopeinsidecornerZPlus() : base("plasterblock", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz+");
        }
    }
}