using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocksilverslopecorneredgeRecipe : BaseRecipe
    {
        public clayblocksilverslopecorneredgeRecipe() : base("clayblocksilverslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocksilverslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblocksilverslopecorneredge : DecorativeType
    {
        public clayblocksilverslopecorneredge() : base("clayblocksilver", "slopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocksilverslopecorneredge.png"))
        {
            this.SideAll = "clayblocksilver";
        }
    }

    [NCAPIType]
    public class clayblocksilverslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblocksilverslopecorneredgeXMinus() : base("clayblocksilver", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblocksilverslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblocksilverslopecorneredgeXPlus() : base("clayblocksilver", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblocksilverslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblocksilverslopecorneredgeZMinus() : base("clayblocksilver", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblocksilverslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblocksilverslopecorneredgeZPlus() : base("clayblocksilver", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez+");
        }
    }
}