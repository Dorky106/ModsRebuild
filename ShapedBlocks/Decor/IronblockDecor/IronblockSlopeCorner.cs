using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class IronblockslopecornerRecipe : BaseRecipe
    {
        public IronblockslopecornerRecipe() : base("ironblockslopecornerrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("ironblock", 1));
            Result.Add(new InventoryItem("ironblockslopecorner", 1));
        }
    }

    [NCAPIType]
    public class Ironblockslopecorner : DecorativeType
    {
        public Ironblockslopecorner() : base("ironblock", "slopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "ironblockslopecorner.png"))
        {
            this.SideAll = "ironblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class ironblockslopecornerXMinus : DecorativeTypeXMinus
    {
        public ironblockslopecornerXMinus() : base("ironblock", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx-");
        }
    }

    [NCAPIType]
    public class ironblockslopecornerXPlus : DecorativeTypeXPlus
    {
        public ironblockslopecornerXPlus() : base("ironblock", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx+");
        }
    }

    [NCAPIType]
    public class ironblockslopecornerZMinus : DecorativeTypeZMinus
    {
        public ironblockslopecornerZMinus() : base("ironblock", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz-");
        }
    }

    [NCAPIType]
    public class ironblockslopecornerZPlus : DecorativeTypeZPlus
    {
        public ironblockslopecornerZPlus() : base("ironblock", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz+");
        }
    }
}