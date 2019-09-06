using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Meshes;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class PlanksspikeRecipe : BaseRecipe
    {
        public PlanksspikeRecipe() : base("planksspikerecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("planks", 1));
            Result.Add(new InventoryItem("planksspike", 1));
        }
    }

    [NCAPIType]
    public class Planksspike : BaseType
    {
        public Planksspike() : base("planksspike", false)
        {
            this.SideAll = "planks";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "planksspike.png");
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
            if (MeshManager.GetMesh(Entry.ModName, "spike", out string mesh))
            {
                this.Mesh = mesh;
            }
        }
    }
}