using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class IronblockupsidedownslopeinsidecornerRecipe : BaseRecipe
    {
        public IronblockupsidedownslopeinsidecornerRecipe() : base("ironblockupsidedownslopeinsidecornerrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("ironblock", 1));
            Result.Add(new InventoryItem("ironblockupsidedownslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class Ironblockupsidedownslopeinsidecorner : DecorativeType
    {
        public Ironblockupsidedownslopeinsidecorner() : base("ironblock", "upsidedownslopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "ironblockupsidedownslopeinsidecorner.png"))
        {
            this.SideAll = "ironblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class ironblockupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public ironblockupsidedownslopeinsidecornerXMinus() : base("ironblock", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class ironblockupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public ironblockupsidedownslopeinsidecornerXPlus() : base("ironblock", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class ironblockupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public ironblockupsidedownslopeinsidecornerZMinus() : base("ironblock", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class ironblockupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public ironblockupsidedownslopeinsidecornerZPlus() : base("ironblock", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz+");
        }
    }
}