using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class IronblocktwostepstairsRecipe : BaseRecipe
    {
        public IronblocktwostepstairsRecipe() : base("ironblocktwostepstairsrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("ironblock", 1));
            Result.Add(new InventoryItem("ironblocktwostepstairs", 1));
        }
    }

    [NCAPIType]
    public class Ironblocktwostepstairs : DecorativeType
    {
        public Ironblocktwostepstairs() : base("ironblock", "twostepstairs",
            Utilities.MultiCombine(Entry.ModIconDirectory, "ironblocktwostepstairs.png"))
        {
            this.SideAll = "ironblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class ironblocktwostepstairsXMinus : DecorativeTypeXMinus
    {
        public ironblocktwostepstairsXMinus() : base("ironblock", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx-");
        }
    }

    [NCAPIType]
    public class ironblocktwostepstairsXPlus : DecorativeTypeXPlus
    {
        public ironblocktwostepstairsXPlus() : base("ironblock", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsx+");
        }
    }

    [NCAPIType]
    public class ironblocktwostepstairsZMinus : DecorativeTypeZMinus
    {
        public ironblocktwostepstairsZMinus() : base("ironblock", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz-");
        }
    }

    [NCAPIType]
    public class ironblocktwostepstairsZPlus : DecorativeTypeZPlus
    {
        public ironblocktwostepstairsZPlus() : base("ironblock", "twostepstairs", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("twostepstairsz+");
        }
    }
}