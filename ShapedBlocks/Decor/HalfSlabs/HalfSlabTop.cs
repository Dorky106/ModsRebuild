using PhentrixGames.NewColonyAPI.Meshes;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor.HalfSlabs
{
    [NCAPIRecipe]
    public class HalfSlabTopRecipe : BaseRecipe
    {
        public HalfSlabTopRecipe() : base("Test.HalfSlabTop", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("planks", 1));
            Result.Add(new InventoryItem("HalfSlabTop", 1));
        }
    }

    [NCAPIType]
    public class HalfSlabTop : BaseType
    {
        public HalfSlabTop() : base("HalfSlabTop", true)
        {
            this.SideAll = "planks";
            this.IsPlaceable = true;
            this.Icon = "halfslab.png";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
            if (MeshManager.GetMesh(Entry.ModName, "halfslabtop2", out string mesh))
            {
                this.Mesh = mesh;
            }
            this.Colors = new string[] { "#ff0000->#eeeeee" };
        }
    }
}