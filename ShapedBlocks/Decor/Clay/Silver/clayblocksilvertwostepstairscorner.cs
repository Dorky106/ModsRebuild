using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocksilvertwostepstairscornerRecipe : BaseRecipe
    {
        public clayblocksilvertwostepstairscornerRecipe() : base("clayblocksilvertwostepstairscornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocksilvertwostepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocksilvertwostepstairscorner : DecorativeType
    {
        public clayblocksilvertwostepstairscorner() : base("clayblocksilver", "twostepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocksilvertwostepstairscorner.png"))
        {
            this.SideAll = "clayblocksilver";
        }
    }

    [NCAPIType]
    public class clayblocksilvertwostepstairscornerXMinus : DecorativeTypeXMinus
    {
        public clayblocksilvertwostepstairscornerXMinus() : base("clayblocksilver", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx-");
        }
    }

    [NCAPIType]
    public class clayblocksilvertwostepstairscornerXPlus : DecorativeTypeXPlus
    {
        public clayblocksilvertwostepstairscornerXPlus() : base("clayblocksilver", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx+");
        }
    }

    [NCAPIType]
    public class clayblocksilvertwostepstairscornerZMinus : DecorativeTypeZMinus
    {
        public clayblocksilvertwostepstairscornerZMinus() : base("clayblocksilver", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz-");
        }
    }

    [NCAPIType]
    public class clayblocksilvertwostepstairscornerZPlus : DecorativeTypeZPlus
    {
        public clayblocksilvertwostepstairscornerZPlus() : base("clayblocksilver", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz+");
        }
    }
}