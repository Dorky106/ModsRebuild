using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class stonebrickstwostepstairsRecipe : BaseRecipe
    {
        public stonebrickstwostepstairsRecipe() : base("stonebrickstwostepstairsrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("stonebricks", 1));
            Result.Add(new InventoryItem("stonebrickstwostepstairs", 1));
        }
    }

    [NCAPIType]
    public class stonebrickstwostepstairs : DecorativeType
    {
        public stonebrickstwostepstairs() : base("stonebricks", "twostepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "stonebrickstwostepstairs.png"))
        {
            this.SideAll = "stonebricks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class stonebrickstwostepstairsXMinus : DecorativeTypeXMinus
    {
        public stonebrickstwostepstairsXMinus() : base("stonebricks", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx-");
        }
    }

    [NCAPIType]
    public class stonebrickstwostepstairsXPlus : DecorativeTypeXPlus
    {
        public stonebrickstwostepstairsXPlus() : base("stonebricks", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx+");
        }
    }

    [NCAPIType]
    public class stonebrickstwostepstairsZMinus : DecorativeTypeZMinus
    {
        public stonebrickstwostepstairsZMinus() : base("stonebricks", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz-");
        }
    }

    [NCAPIType]
    public class stonebrickstwostepstairsZPlus : DecorativeTypeZPlus
    {
        public stonebrickstwostepstairsZPlus() : base("stonebricks", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz+");
        }
    }
}