using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpurpletwostepstairscornerRecipe : BaseRecipe
    {
        public clayblockpurpletwostepstairscornerRecipe() : base("clayblockpurpletwostepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpurpletwostepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockpurpletwostepstairscorner : DecorativeType
    {
        public clayblockpurpletwostepstairscorner() : base("clayblockpurple", "twostepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpurpletwostepstairscorner.png"))
        {
            this.SideAll = "clayblockpurple";
        }
    }

    [NCAPIType]
    public class clayblockpurpletwostepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblockpurpletwostepstairscornerXMinus() : base("clayblockpurple", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblockpurpletwostepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblockpurpletwostepstairscornerXPlus() : base("clayblockpurple", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblockpurpletwostepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblockpurpletwostepstairscornerZMinus() : base("clayblockpurple", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblockpurpletwostepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblockpurpletwostepstairscornerZPlus() : base("clayblockpurple", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz+");
        }
    }
}