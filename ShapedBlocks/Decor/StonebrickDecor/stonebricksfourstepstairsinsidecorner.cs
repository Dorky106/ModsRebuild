using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class stonebricksfourstepstairsinsidecornerRecipe : BaseRecipe
    {
        public stonebricksfourstepstairsinsidecornerRecipe() : base("stonebricksfourstepstairsinsidecornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("stonebricks", 1));
            Result.Add(new InventoryItem("stonebricksfourstepstairsinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class stonebricksfourstepstairsinsidecorner : DecorativeType
    {
        public stonebricksfourstepstairsinsidecorner() : base("stonebricks", "fourstepstairsinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "stonebricksfourstepstairsinsidecorner.png"))
        {
            this.SideAll = "stonebricks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class stonebricksfourstepstairsinsidecornerXMinus : DecorativeTypeXMinus
    {
        public stonebricksfourstepstairsinsidecornerXMinus() : base("stonebricks", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx-");
        }
    }

    [NCAPIType]
    public class stonebricksfourstepstairsinsidecornerXPlus : DecorativeTypeXPlus
    {
        public stonebricksfourstepstairsinsidecornerXPlus() : base("stonebricks", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerx+");
        }
    }

    [NCAPIType]
    public class stonebricksfourstepstairsinsidecornerZMinus : DecorativeTypeZMinus
    {
        public stonebricksfourstepstairsinsidecornerZMinus() : base("stonebricks", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz-");
        }
    }

    [NCAPIType]
    public class stonebricksfourstepstairsinsidecornerZPlus : DecorativeTypeZPlus
    {
        public stonebricksfourstepstairsinsidecornerZPlus() : base("stonebricks", "fourstepstairsinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsinsidecornerz+");
        }
    }
}