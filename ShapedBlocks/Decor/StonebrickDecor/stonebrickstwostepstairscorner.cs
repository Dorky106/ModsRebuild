using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class stonebrickstwostepstairscornerRecipe : BaseRecipe
    {
        public stonebrickstwostepstairscornerRecipe() : base("stonebrickstwostepstairscornerrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("stonebricks", 1));
            Result.Add(new InventoryItem("stonebrickstwostepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class stonebrickstwostepstairscorner : DecorativeType
    {
        public stonebrickstwostepstairscorner() : base("stonebricks", "twostepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "stonebrickstwostepstairscorner.png"))
        {
            this.SideAll = "stonebricks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class stonebrickstwostepstairscornerXMinus : DecorativeTypeXMinus
    {
        public stonebrickstwostepstairscornerXMinus() : base("stonebricks", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx-");
        }
    }

    [NCAPIType]
    public class stonebrickstwostepstairscornerXPlus : DecorativeTypeXPlus
    {
        public stonebrickstwostepstairscornerXPlus() : base("stonebricks", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerx+");
        }
    }

    [NCAPIType]
    public class stonebrickstwostepstairscornerZMinus : DecorativeTypeZMinus
    {
        public stonebrickstwostepstairscornerZMinus() : base("stonebricks", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz-");
        }
    }

    [NCAPIType]
    public class stonebrickstwostepstairscornerZPlus : DecorativeTypeZPlus
    {
        public stonebrickstwostepstairscornerZPlus() : base("stonebricks", "twostepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairscornerz+");
        }
    }
}