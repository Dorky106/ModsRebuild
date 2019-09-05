using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class stonebricksfourstepstairscornerRecipe : BaseRecipe
    {
        public stonebricksfourstepstairscornerRecipe() : base("stonebricksfourstepstairscornerrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("stonebricks", 1));
            Result.Add(new InventoryItem("stonebricksfourstepstairscorner", 1));
        }
    }

    [NCAPIType]
    public class stonebricksfourstepstairscorner : DecorativeType
    {
        public stonebricksfourstepstairscorner() : base("stonebricks", "fourstepstairscorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "stonebricksfourstepstairscorner.png"))
        {
            this.SideAll = "stonebricks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class stonebricksfourstepstairscornerXMinus : DecorativeTypeXMinus
    {
        public stonebricksfourstepstairscornerXMinus() : base("stonebricks", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx-");
        }
    }

    [NCAPIType]
    public class stonebricksfourstepstairscornerXPlus : DecorativeTypeXPlus
    {
        public stonebricksfourstepstairscornerXPlus() : base("stonebricks", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerx+");
        }
    }

    [NCAPIType]
    public class stonebricksfourstepstairscornerZMinus : DecorativeTypeZMinus
    {
        public stonebricksfourstepstairscornerZMinus() : base("stonebricks", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz-");
        }
    }

    [NCAPIType]
    public class stonebricksfourstepstairscornerZPlus : DecorativeTypeZPlus
    {
        public stonebricksfourstepstairscornerZPlus() : base("stonebricks", "fourstepstairscorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairscornerz+");
        }
    }
}