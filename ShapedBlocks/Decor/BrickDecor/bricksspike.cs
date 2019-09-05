using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Meshes;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class bricksspikeRecipe : BaseRecipe
    {
        public bricksspikeRecipe() : base("bricksspikerecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("bricks", 1));
            Result.Add(new InventoryItem("bricksspike", 1));
        }
    }

    [NCAPIType]
    public class bricksspike : BaseType
    {
        public bricksspike() : base("bricksspike", true)
        {
            this.SideAll = "bricks";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "bricksspike.png");
            if (MeshManager.GetMesh(Entry.ModName, "spike", out string mesh))
            {
                this.Categories = new System.Collections.Generic.List<string> { "decorative" };
                this.Mesh = mesh;
            }
        }
    }
}