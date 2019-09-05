using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocksilverupsidedownslopecorneredgeRecipe : BaseRecipe
    {
        public clayblocksilverupsidedownslopecorneredgeRecipe() : base("clayblocksilverupsidedownslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocksilverupsidedownslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedownslopecorneredge : DecorativeType
    {
        public clayblocksilverupsidedownslopecorneredge() : base("clayblocksilver", "upsidedownslopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocksilverupsidedownslopecorneredge.png"))
        {
            this.SideAll = "clayblocksilver";
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblocksilverupsidedownslopecorneredgeXMinus() : base("clayblocksilver", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblocksilverupsidedownslopecorneredgeXPlus() : base("clayblocksilver", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblocksilverupsidedownslopecorneredgeZMinus() : base("clayblocksilver", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblocksilverupsidedownslopecorneredgeZPlus() : base("clayblocksilver", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez+");
        }
    }
}