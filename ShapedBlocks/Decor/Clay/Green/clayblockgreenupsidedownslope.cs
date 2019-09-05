using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgreenupsidedownslopeRecipe : BaseRecipe
    {
        public clayblockgreenupsidedownslopeRecipe() : base("clayblockgreenupsidedownsloperecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgreenupsidedownslope", 1));
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedownslope : DecorativeType
    {
        public clayblockgreenupsidedownslope() : base("clayblockgreen", "upsidedownslope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgreenupsidedownslope.png"))
        {
            this.SideAll = "clayblockgreen";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedownslopeXMinus : DecorativeTypeXMinus
    {
        public clayblockgreenupsidedownslopeXMinus() : base("clayblockgreen", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex-");
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedownslopeXPlus : DecorativeTypeXPlus
    {
        public clayblockgreenupsidedownslopeXPlus() : base("clayblockgreen", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopex+");
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedownslopeZMinus : DecorativeTypeZMinus
    {
        public clayblockgreenupsidedownslopeZMinus() : base("clayblockgreen", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez-");
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedownslopeZPlus : DecorativeTypeZPlus
    {
        public clayblockgreenupsidedownslopeZPlus() : base("clayblockgreen", "upsidedownslope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopez+");
        }
    }
}