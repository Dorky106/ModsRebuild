using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class stonebricksupsidedownslopecorneredgeRecipe : BaseRecipe
    {
        public stonebricksupsidedownslopecorneredgeRecipe() : base("stonebricksupsidedownslopecorneredgerecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("stonebricks", 1));
            Result.Add(new InventoryItem("stonebricksupsidedownslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class stonebricksupsidedownslopecorneredge : DecorativeType
    {
        public stonebricksupsidedownslopecorneredge() : base("stonebricks", "upsidedownslopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "stonebricksupsidedownslopecorneredge.png"))
        {
            this.SideAll = "stonebricks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class stonebricksupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public stonebricksupsidedownslopecorneredgeXMinus() : base("stonebricks", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex-");
        }
    }

    [NCAPIType]
    public class stonebricksupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public stonebricksupsidedownslopecorneredgeXPlus() : base("stonebricks", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex+");
        }
    }

    [NCAPIType]
    public class stonebricksupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public stonebricksupsidedownslopecorneredgeZMinus() : base("stonebricks", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez-");
        }
    }

    [NCAPIType]
    public class stonebricksupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public stonebricksupsidedownslopecorneredgeZPlus() : base("stonebricks", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez+");
        }
    }
}