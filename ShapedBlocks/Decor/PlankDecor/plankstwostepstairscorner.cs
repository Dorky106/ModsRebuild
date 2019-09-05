using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class PlankstwostepstairscornerRecipe : BaseRecipe
    {
        public PlankstwostepstairscornerRecipe() : base("plankstwostepstairscornerrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("planks", 1));
            Result.Add(new InventoryItem("plankstwostepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class Plankstwostepstairscorner : DecorativeType
    {
        public Plankstwostepstairscorner() : base("planks", "twostepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "plankstwostepstairscorner.png"))
        {
            this.SideAll = "planks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class PlankstwostepstairscornerXMinus : DecorativeTypeXMinus
    {
        public PlankstwostepstairscornerXMinus() : base("planks", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx-");
        }
    }

    [NCAPIType]
    public class PlankstwostepstairscornerXPlus : DecorativeTypeXPlus
    {
        public PlankstwostepstairscornerXPlus() : base("planks", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx+");
        }
    }

    [NCAPIType]
    public class PlankstwostepstairscornerZMinus : DecorativeTypeZMinus
    {
        public PlankstwostepstairscornerZMinus() : base("planks", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz-");
        }
    }

    [NCAPIType]
    public class PlankstwostepstairscornerZPlus : DecorativeTypeZPlus
    {
        public PlankstwostepstairscornerZPlus() : base("planks", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz+");
        }
    }
}