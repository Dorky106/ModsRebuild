using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocksilverslopecornerRecipe : BaseRecipe
    {
        public clayblocksilverslopecornerRecipe() : base("clayblocksilverslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocksilverslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocksilverslopecorner : DecorativeType
    {
        public clayblocksilverslopecorner() : base("clayblocksilver", "slopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocksilverslopecorner.png"))
        {
            this.SideAll = "clayblocksilver";
        }
    }

    [NCAPIType]
    public class clayblocksilverslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblocksilverslopecornerXMinus() : base("clayblocksilver", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblocksilverslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblocksilverslopecornerXPlus() : base("clayblocksilver", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblocksilverslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblocksilverslopecornerZMinus() : base("clayblocksilver", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblocksilverslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblocksilverslopecornerZPlus() : base("clayblocksilver", "slopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecornerz+");
        }
    }
}