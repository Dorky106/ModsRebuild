using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class IronblocktwostepstairscornerRecipe : BaseRecipe
    {
        public IronblocktwostepstairscornerRecipe() : base("ironblocktwostepstairscornerrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("ironblock", 1));
            Result.Add(new InventoryItem("ironblocktwostepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class Ironblocktwostepstairscorner : DecorativeType
    {
        public Ironblocktwostepstairscorner() : base("ironblock", "twostepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "ironblocktwostepstairscorner.png"))
        {
            this.SideAll = "ironblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class ironblocktwostepstairscornerXMinus : DecorativeTypeXMinus
    {
        public ironblocktwostepstairscornerXMinus() : base("ironblock", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx-");
        }
    }

    [NCAPIType]
    public class ironblocktwostepstairscornerXPlus : DecorativeTypeXPlus
    {
        public ironblocktwostepstairscornerXPlus() : base("ironblock", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx+");
        }
    }

    [NCAPIType]
    public class ironblocktwostepstairscornerZMinus : DecorativeTypeZMinus
    {
        public ironblocktwostepstairscornerZMinus() : base("ironblock", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz-");
        }
    }

    [NCAPIType]
    public class ironblocktwostepstairscornerZPlus : DecorativeTypeZPlus
    {
        public ironblocktwostepstairscornerZPlus() : base("ironblock", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz+");
        }
    }
}