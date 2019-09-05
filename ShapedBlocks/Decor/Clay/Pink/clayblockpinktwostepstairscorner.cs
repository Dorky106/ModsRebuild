using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpinktwostepstairscornerRecipe : BaseRecipe
    {
        public clayblockpinktwostepstairscornerRecipe() : base("clayblockpinktwostepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpinktwostepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockpinktwostepstairscorner : DecorativeType
    {
        public clayblockpinktwostepstairscorner() : base("clayblockpink", "twostepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpinktwostepstairscorner.png"))
        {
            this.SideAll = "clayblockpink";
        }
    }

    [NCAPIType]
    public class clayblockpinktwostepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockpinktwostepstairscornerXMinus() : base("clayblockpink", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockpinktwostepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockpinktwostepstairscornerXPlus() : base("clayblockpink", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockpinktwostepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockpinktwostepstairscornerZMinus() : base("clayblockpink", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockpinktwostepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockpinktwostepstairscornerZPlus() : base("clayblockpink", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz+");
        }
    }
}