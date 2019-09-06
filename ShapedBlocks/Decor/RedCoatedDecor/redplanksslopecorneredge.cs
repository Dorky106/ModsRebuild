using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class redplanksslopecorneredgeRecipe : BaseRecipe
    {
        public redplanksslopecorneredgeRecipe() : base("redplanksslopecorneredgerecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("redplanks", 1));
            Result.Add(new InventoryItem("redplanksslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class redplanksslopecorneredge : DecorativeType
    {
        public redplanksslopecorneredge() : base("redplanks", "slopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "redplanksslopecorneredge.png"))
        {
            this.SideAll = "redplanks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class redplanksslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public redplanksslopecorneredgeXMinus() : base("redplanks", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex-");
        }
    }

    [NCAPIType]
    public class redplanksslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public redplanksslopecorneredgeXPlus() : base("redplanks", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex+");
        }
    }

    [NCAPIType]
    public class redplanksslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public redplanksslopecorneredgeZMinus() : base("redplanks", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez-");
        }
    }

    [NCAPIType]
    public class redplanksslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public redplanksslopecorneredgeZPlus() : base("redplanks", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez+");
        }
    }
}