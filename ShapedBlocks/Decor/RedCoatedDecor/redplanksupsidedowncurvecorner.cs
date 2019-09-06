using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class redplanksupsidedowncurvecornerRecipe : BaseRecipe
    {
        public redplanksupsidedowncurvecornerRecipe() : base("redplanksupsidedowncurvecornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("redplanks", 1));
            Result.Add(new InventoryItem("redplanksupsidedowncurvecorner", 1));
        }
    }

    [NCAPIType]
    public class redplanksupsidedowncurvecorner : DecorativeType
    {
        public redplanksupsidedowncurvecorner() : base("redplanks", "upsidedowncurvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "redplanksupsidedowncurvecorner.png"))
        {
            this.SideAll = "redplanks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class redplanksupsidedowncurvecornerXMinus : DecorativeTypeXMinus
    {
        public redplanksupsidedowncurvecornerXMinus() : base("redplanks", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx-");
        }
    }

    [NCAPIType]
    public class redplanksupsidedowncurvecornerXPlus : DecorativeTypeXPlus
    {
        public redplanksupsidedowncurvecornerXPlus() : base("redplanks", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx+");
        }
    }

    [NCAPIType]
    public class redplanksupsidedowncurvecornerZMinus : DecorativeTypeZMinus
    {
        public redplanksupsidedowncurvecornerZMinus() : base("redplanks", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz-");
        }
    }

    [NCAPIType]
    public class redplanksupsidedowncurvecornerZPlus : DecorativeTypeZPlus
    {
        public redplanksupsidedowncurvecornerZPlus() : base("redplanks", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz+");
        }
    }
}