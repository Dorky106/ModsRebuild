using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class redplanksupsidedownslopecorneredgeRecipe : BaseRecipe
    {
        public redplanksupsidedownslopecorneredgeRecipe() : base("redplanksupsidedownslopecorneredgerecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("redplanks", 1));
            Result.Add(new InventoryItem("redplanksupsidedownslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class redplanksupsidedownslopecorneredge : DecorativeType
    {
        public redplanksupsidedownslopecorneredge() : base("redplanks", "upsidedownslopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "redplanksupsidedownslopecorneredge.png"))
        {
            this.SideAll = "redplanks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class redplanksupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public redplanksupsidedownslopecorneredgeXMinus() : base("redplanks", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex-");
        }
    }

    [NCAPIType]
    public class redplanksupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public redplanksupsidedownslopecorneredgeXPlus() : base("redplanks", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex+");
        }
    }

    [NCAPIType]
    public class redplanksupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public redplanksupsidedownslopecorneredgeZMinus() : base("redplanks", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez-");
        }
    }

    [NCAPIType]
    public class redplanksupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public redplanksupsidedownslopecorneredgeZPlus() : base("redplanks", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez+");
        }
    }
}