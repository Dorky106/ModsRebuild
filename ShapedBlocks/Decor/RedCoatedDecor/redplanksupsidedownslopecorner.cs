using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class redplanksupsidedownslopecornerRecipe : BaseRecipe
    {
        public redplanksupsidedownslopecornerRecipe() : base("redplanksupsidedownslopecornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("redplanks", 1));
            Result.Add(new InventoryItem("redplanksupsidedownslopecorner", 1));
        }
    }

    [NCAPIType]
    public class redplanksupsidedownslopecorner : DecorativeType
    {
        public redplanksupsidedownslopecorner() : base("redplanks", "upsidedownslopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "redplanksupsidedownslopecorner.png"))
        {
            this.SideAll = "redplanks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class redplanksupsidedownslopecornerXMinus : DecorativeTypeXMinus
    {
        public redplanksupsidedownslopecornerXMinus() : base("redplanks", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx-");
        }
    }

    [NCAPIType]
    public class redplanksupsidedownslopecornerXPlus : DecorativeTypeXPlus
    {
        public redplanksupsidedownslopecornerXPlus() : base("redplanks", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx+");
        }
    }

    [NCAPIType]
    public class redplanksupsidedownslopecornerZMinus : DecorativeTypeZMinus
    {
        public redplanksupsidedownslopecornerZMinus() : base("redplanks", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz-");
        }
    }

    [NCAPIType]
    public class redplanksupsidedownslopecornerZPlus : DecorativeTypeZPlus
    {
        public redplanksupsidedownslopecornerZPlus() : base("redplanks", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz+");
        }
    }
}