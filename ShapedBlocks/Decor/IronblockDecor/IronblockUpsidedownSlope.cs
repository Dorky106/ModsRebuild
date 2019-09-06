using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class IronblockupsidedownslopeRecipe : BaseRecipe
    {
        public IronblockupsidedownslopeRecipe() : base("ironblockupsidedownsloperecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("ironblock", 1));
            Result.Add(new InventoryItem("ironblockupsidedownslope", 1));
        }
    }

    [NCAPIType]
    public class Ironblockupsidedownslope : DecorativeType
    {
        public Ironblockupsidedownslope() : base("ironblock", "upsidedownslope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "ironblockupsidedownslope.png"))
        {
            this.SideAll = "ironblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class ironblockupsidedownslopeXMinus : DecorativeTypeXMinus
    {
        public ironblockupsidedownslopeXMinus() : base("ironblock", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex-");
        }
    }

    [NCAPIType]
    public class ironblockupsidedownslopeXPlus : DecorativeTypeXPlus
    {
        public ironblockupsidedownslopeXPlus() : base("ironblock", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex+");
        }
    }

    [NCAPIType]
    public class ironblockupsidedownslopeZMinus : DecorativeTypeZMinus
    {
        public ironblockupsidedownslopeZMinus() : base("ironblock", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez-");
        }
    }

    [NCAPIType]
    public class ironblockupsidedownslopeZPlus : DecorativeTypeZPlus
    {
        public ironblockupsidedownslopeZPlus() : base("ironblock", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez+");
        }
    }
}