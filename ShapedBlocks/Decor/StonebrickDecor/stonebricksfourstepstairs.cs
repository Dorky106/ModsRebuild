using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class stonebricksfourstepstairsRecipe : BaseRecipe
    {
        public stonebricksfourstepstairsRecipe() : base("stonebricksfourstepstairsrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("stonebricks", 1));
            Result.Add(new InventoryItem("stonebricksfourstepstairs", 1));
        }
    }

    [NCAPIType]
    public class stonebricksfourstepstairs : DecorativeType
    {
        public stonebricksfourstepstairs() : base("stonebricks", "fourstepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "stonebricksfourstepstairs.png"))
        {
            this.SideAll = "stonebricks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class stonebricksfourstepstairsXMinus : DecorativeTypeXMinus
    {
        public stonebricksfourstepstairsXMinus() : base("stonebricks", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx-");
        }
    }

    [NCAPIType]
    public class stonebricksfourstepstairsXPlus : DecorativeTypeXPlus
    {
        public stonebricksfourstepstairsXPlus() : base("stonebricks", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsx+");
        }
    }

    [NCAPIType]
    public class stonebricksfourstepstairsZMinus : DecorativeTypeZMinus
    {
        public stonebricksfourstepstairsZMinus() : base("stonebricks", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz-");
        }
    }

    [NCAPIType]
    public class stonebricksfourstepstairsZPlus : DecorativeTypeZPlus
    {
        public stonebricksfourstepstairsZPlus() : base("stonebricks", "fourstepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("fourstepstairsz+");
        }
    }
}