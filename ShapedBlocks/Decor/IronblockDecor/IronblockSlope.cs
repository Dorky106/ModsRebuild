using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class IronblockslopeRecipe : BaseRecipe
    {
        public IronblockslopeRecipe() : base("ironblocksloperecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("ironblock", 1));
            Result.Add(new InventoryItem("ironblockslope", 1));
        }
    }

    [NCAPIType]
    public class Ironblockslope : DecorativeType
    {
        public Ironblockslope() : base("ironblock", "slope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "ironblockslope.png"))
        {
            this.SideAll = "ironblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class ironblockslopeXMinus : DecorativeTypeXMinus
    {
        public ironblockslopeXMinus() : base("ironblock", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex-");
        }
    }

    [NCAPIType]
    public class ironblockslopeXPlus : DecorativeTypeXPlus
    {
        public ironblockslopeXPlus() : base("ironblock", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopex+");
        }
    }

    [NCAPIType]
    public class ironblockslopeZMinus : DecorativeTypeZMinus
    {
        public ironblockslopeZMinus() : base("ironblock", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez-");
        }
    }

    [NCAPIType]
    public class ironblockslopeZPlus : DecorativeTypeZPlus
    {
        public ironblockslopeZPlus() : base("ironblock", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopez+");
        }
    }
}