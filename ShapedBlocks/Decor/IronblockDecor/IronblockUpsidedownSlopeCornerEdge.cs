using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class ironblockupsidedownslopecorneredgeRecipe : BaseRecipe
    {
        public ironblockupsidedownslopecorneredgeRecipe() : base("ironblockupsidedownslopecorneredgerecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("ironblock", 1));
            Result.Add(new InventoryItem("ironblockupsidedownslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class Ironblockupsidedownslopecorneredge : DecorativeType
    {
        public Ironblockupsidedownslopecorneredge() : base("ironblock", "upsidedownslopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "ironblockupsidedownslopecorneredge.png"))
        {
            this.SideAll = "ironblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class ironblockupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public ironblockupsidedownslopecorneredgeXMinus() : base("ironblock", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex-");
        }
    }

    [NCAPIType]
    public class ironblockupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public ironblockupsidedownslopecorneredgeXPlus() : base("ironblock", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex+");
        }
    }

    [NCAPIType]
    public class ironblockupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public ironblockupsidedownslopecorneredgeZMinus() : base("ironblock", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez-");
        }
    }

    [NCAPIType]
    public class ironblockupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public ironblockupsidedownslopecorneredgeZPlus() : base("ironblock", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez+");
        }
    }
}