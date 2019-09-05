using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class plasterblockslopeRecipe : BaseRecipe
    {
        public plasterblockslopeRecipe() : base("plasterblocksloperecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("plasterblock", 1));
            Result.Add(new InventoryItem("plasterblockslope", 1));
        }
    }

    [NCAPIType]
    public class plasterblockslope : DecorativeType
    {
        public plasterblockslope() : base("plasterblock", "slope",
            Utilities.MultiCombine(Entry.ModIconDirectory, "plasterblockslope.png"))
        {
            this.SideAll = "plasterblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class plasterblockslopeXMinus : DecorativeTypeXMinus
    {
        public plasterblockslopeXMinus() : base("plasterblock", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class plasterblockslopeXPlus : DecorativeTypeXPlus
    {
        public plasterblockslopeXPlus() : base("plasterblock", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class plasterblockslopeZMinus : DecorativeTypeZMinus
    {
        public plasterblockslopeZMinus() : base("plasterblock", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class plasterblockslopeZPlus : DecorativeTypeZPlus
    {
        public plasterblockslopeZPlus() : base("plasterblock", "slope", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}