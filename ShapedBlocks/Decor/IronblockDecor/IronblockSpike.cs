using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Meshes;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class IronblockspikeRecipe : BaseRecipe
    {
        public IronblockspikeRecipe() : base("ironblockspikerecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("ironblock", 1));
            Result.Add(new InventoryItem("ironblockspike", 1));
        }
    }

    [NCAPIType]
    public class Ironblockspike : BaseType
    {
        public Ironblockspike() : base("ironblockspike", false)
        {
            this.SideAll = "ironblock";
            this.IsPlaceable = true;
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "ironblockspike.png");
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
            if (MeshManager.GetMesh(Entry.ModName, "spike", out string mesh))
            {
                this.Mesh = mesh;
            }
        }
    }
}