using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Meshes;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class plasterblockspikeRecipe : BaseRecipe
    {
        public plasterblockspikeRecipe() : base("plasterblockspikerecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("plasterblock", 1));
            Result.Add(new InventoryItem("plasterblockspike", 1));
        }
    }

    [NCAPIType]
    public class plasterblockspike : BaseType
    {
        public plasterblockspike() : base("plasterblockspike", true)
        {
            this.SideAll = "plasterblock";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "plasterblockspike.png");
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
            if (MeshManager.GetMesh(Entry.ModName, "spike", out string mesh))
            {
                this.Mesh = mesh;
            }
        }
    }
}