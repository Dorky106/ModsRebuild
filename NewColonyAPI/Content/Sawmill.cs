using PhentrixGames.NewColonyAPI.Meshes;
using PhentrixGames.NewColonyAPI.Power;
using PhentrixGames.NewColonyAPI.Recipe;
using static PhentrixGames.NewColonyAPI.Power.PowerManager;

namespace PhentrixGames.NewColonyAPI.Content
{
    [NCAPIPowerType]
    public class SawmillBlock : Types.BaseType
    {
        public SawmillBlock() : base("Sawmill", false)
        {
            if (MeshManager.GetMesh(NewColonyAPIEntry.ModName, "sawmill", out string mesh))
            {
                this.Mesh = mesh;
            }
            //this.Colliders = Helpers.Colliders.GetColliders("twohigh");
            this.Icon = Helpers.Utilities.MultiCombine(NewColonyAPIEntry.ModIconDirectory, "sawmill.png");
            this.IsPlaceable = true;
            PowerManager.ValidateBlockID(this.TypeName, new Sawmill());
        }
    }

    public class Sawmill : Machine
    {
        public Sawmill() : base("Sawmill", 200, 2)
        {
        }
    }

    [RecipeManager.NCAPIRecipe]
    public class sawmilllogtaigaRecipe : BaseRecipe
    {
        public sawmilllogtaigaRecipe() : base("sawmill.logtaiga.planks", "phentrixgames.sawmill", false)
        {
            Requirements.Add(new InventoryItem("logtaiga", 1));
            Result.Add(new InventoryItem("planks", 6));
        }
    }

    [RecipeManager.NCAPIRecipe]
    public class sawmillloglogtemperateRecipe : BaseRecipe
    {
        public sawmillloglogtemperateRecipe() : base("sawmill.logtemperate.planks", "phentrixgames.sawmill", false)
        {
            Requirements.Add(new InventoryItem("logtemperate", 1));
            Result.Add(new InventoryItem("planks", 6));
        }
    }
}