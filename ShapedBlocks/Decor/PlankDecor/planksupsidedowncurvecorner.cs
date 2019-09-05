using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class planksupsidedowncurvecornerRecipe : BaseRecipe
    {
        public planksupsidedowncurvecornerRecipe() : base("planksupsidedowncurvecornerrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("planks", 1));
            Result.Add(new InventoryItem("planksupsidedowncurvecorner", 1));
        }
    }

    [NCAPIType]
    public class planksupsidedowncurvecorner : DecorativeType
    {
        public planksupsidedowncurvecorner() : base("planks", "upsidedowncurvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "planksupsidedowncurvecorner.png"))
        {
            this.SideAll = "planks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class planksupsidedowncurvecornerXMinus : DecorativeTypeXMinus
    {
        public planksupsidedowncurvecornerXMinus() : base("planks", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx-");
        }
    }

    [NCAPIType]
    public class planksupsidedowncurvecornerXPlus : DecorativeTypeXPlus
    {
        public planksupsidedowncurvecornerXPlus() : base("planks", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx+");
        }
    }

    [NCAPIType]
    public class planksupsidedowncurvecornerZMinus : DecorativeTypeZMinus
    {
        public planksupsidedowncurvecornerZMinus() : base("planks", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz-");
        }
    }

    [NCAPIType]
    public class planksupsidedowncurvecornerZPlus : DecorativeTypeZPlus
    {
        public planksupsidedowncurvecornerZPlus() : base("planks", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz+");
        }
    }
}