using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class stonebricksslopecorneredgeRecipe : BaseRecipe
    {
        public stonebricksslopecorneredgeRecipe() : base("stonebricksslopecorneredgerecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("stonebricks", 1));
            Result.Add(new InventoryItem("stonebricksslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class stonebricksslopecorneredge : DecorativeType
    {
        public stonebricksslopecorneredge() : base("stonebricks", "slopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "stonebricksslopecorneredge.png"))
        {
            this.SideAll = "stonebricks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class stonebricksslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public stonebricksslopecorneredgeXMinus() : base("stonebricks", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex-");
        }
    }

    [NCAPIType]
    public class stonebricksslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public stonebricksslopecorneredgeXPlus() : base("stonebricks", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgex+");
        }
    }

    [NCAPIType]
    public class stonebricksslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public stonebricksslopecorneredgeZMinus() : base("stonebricks", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez-");
        }
    }

    [NCAPIType]
    public class stonebricksslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public stonebricksslopecorneredgeZPlus() : base("stonebricks", "slopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("slopecorneredgez+");
        }
    }
}