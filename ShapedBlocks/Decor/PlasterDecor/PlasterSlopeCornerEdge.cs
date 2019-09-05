using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class plasterblockslopecorneredgeRecipe : BaseRecipe
    {
        public plasterblockslopecorneredgeRecipe() : base("plasterblockslopecorneredgerecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("plasterblock", 1));
            Result.Add(new InventoryItem("plasterblockslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class plasterblockslopecorneredge : DecorativeType
    {
        public plasterblockslopecorneredge() : base("plasterblock", "slopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "plasterblockslopecorneredge.png"))
        {
            this.SideAll = "plasterblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class plasterblockslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public plasterblockslopecorneredgeXMinus() : base("plasterblock", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex-");
        }
    }

    [NCAPIType]
    public class plasterblockslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public plasterblockslopecorneredgeXPlus() : base("plasterblock", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex+");
        }
    }

    [NCAPIType]
    public class plasterblockslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public plasterblockslopecorneredgeZMinus() : base("plasterblock", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez-");
        }
    }

    [NCAPIType]
    public class plasterblockslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public plasterblockslopecorneredgeZPlus() : base("plasterblock", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez+");
        }
    }
}