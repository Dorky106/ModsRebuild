using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class IronblockslopeinsidecornerRecipe : BaseRecipe
    {
        public IronblockslopeinsidecornerRecipe() : base("ironblockslopeinsidecornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("ironblock", 1));
            Result.Add(new InventoryItem("ironblockslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class Ironblockslopeinsidecorner : DecorativeType
    {
        public Ironblockslopeinsidecorner() : base("ironblock", "slopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "ironblockslopeinsidecorner.png"))
        {
            this.SideAll = "ironblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class ironblockslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public ironblockslopeinsidecornerXMinus() : base("ironblock", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class ironblockslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public ironblockslopeinsidecornerXPlus() : base("ironblock", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class ironblockslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public ironblockslopeinsidecornerZMinus() : base("ironblock", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class ironblockslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public ironblockslopeinsidecornerZPlus() : base("ironblock", "slopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopeinsidecornerz+");
        }
    }
}