using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class plasterblocktwostepstairscornerRecipe : BaseRecipe
    {
        public plasterblocktwostepstairscornerRecipe() : base("plasterblocktwostepstairscornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("plasterblock", 1));
            Result.Add(new InventoryItem("plasterblocktwostepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class plasterblocktwostepstairscorner : DecorativeType
    {
        public plasterblocktwostepstairscorner() : base("plasterblock", "twostepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "plasterblocktwostepstairscorner.png"))
        {
            this.SideAll = "plasterblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class plasterblocktwostepstairscornerXMinus : DecorativeTypeXMinus
    {
        public plasterblocktwostepstairscornerXMinus() : base("plasterblock", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx-");
        }
    }

    [NCAPIType]
    public class plasterblocktwostepstairscornerXPlus : DecorativeTypeXPlus
    {
        public plasterblocktwostepstairscornerXPlus() : base("plasterblock", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx+");
        }
    }

    [NCAPIType]
    public class plasterblocktwostepstairscornerZMinus : DecorativeTypeZMinus
    {
        public plasterblocktwostepstairscornerZMinus() : base("plasterblock", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz-");
        }
    }

    [NCAPIType]
    public class plasterblocktwostepstairscornerZPlus : DecorativeTypeZPlus
    {
        public plasterblocktwostepstairscornerZPlus() : base("plasterblock", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz+");
        }
    }
}