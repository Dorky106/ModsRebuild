using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class plasterblockupsidedownslopeRecipe : BaseRecipe
    {
        public plasterblockupsidedownslopeRecipe() : base("plasterblockupsidedownsloperecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("plasterblock", 1));
            Result.Add(new InventoryItem("plasterblockupsidedownslope", 1));
        }
    }

    [NCAPIType]
    public class plasterblockupsidedownslope : DecorativeType
    {
        public plasterblockupsidedownslope() : base("plasterblock", "upsidedownslope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "plasterblockupsidedownslope.png"))
        {
            this.SideAll = "plasterblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class plasterblockupsidedownslopeXMinus : DecorativeTypeXMinus
    {
        public plasterblockupsidedownslopeXMinus() : base("plasterblock", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex-");
        }
    }

    [NCAPIType]
    public class plasterblockupsidedownslopeXPlus : DecorativeTypeXPlus
    {
        public plasterblockupsidedownslopeXPlus() : base("plasterblock", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex+");
        }
    }

    [NCAPIType]
    public class plasterblockupsidedownslopeZMinus : DecorativeTypeZMinus
    {
        public plasterblockupsidedownslopeZMinus() : base("plasterblock", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez-");
        }
    }

    [NCAPIType]
    public class plasterblockupsidedownslopeZPlus : DecorativeTypeZPlus
    {
        public plasterblockupsidedownslopeZPlus() : base("plasterblock", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez+");
        }
    }
}