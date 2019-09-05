using PhentrixGames.NewColonyAPI.Meshes;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor.HalfSlabs
{
    [NCAPIRecipe]
    public class HalfSlabBottomRecipe : BaseRecipe
    {
        public HalfSlabBottomRecipe() : base("Test.HalfSlabBottom", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("planks", 1));
            Result.Add(new InventoryItem("HalfSlabBottom", 1));
        }
    }

    [NCAPIType]
    public class HalfSlabBottom : BaseType
    {
        public HalfSlabBottom() : base("HalfSlabBottom", true)
        {
            this.SideAll = "planks";
            this.IsPlaceable = true;
            this.Icon = "halfslab.png";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
            if (MeshManager.GetMesh(Entry.ModName, "halfslabbottom2", out string mesh))
            {
                this.Mesh = mesh;
            }
            this.Colors = new string[] { "#ff0000->#eeeeee" };
        }
    }
}