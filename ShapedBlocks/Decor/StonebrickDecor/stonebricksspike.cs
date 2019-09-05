using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Meshes;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class stonebricksspikeRecipe : BaseRecipe
    {
        public stonebricksspikeRecipe() : base("stonebricksspikerecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("stonebricks", 1));
            Result.Add(new InventoryItem("stonebricksspike", 1));
        }
    }

    [NCAPIType]
    public class stonebricksspike : BaseType
    {
        public stonebricksspike() : base("stonebricksspike", true)
        {
            this.SideAll = "stonebricks";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "stonebricksspike.png");
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
            if (MeshManager.GetMesh(Entry.ModName, "spike", out string mesh))
            {
                this.Mesh = mesh;
            }
        }
    }
}