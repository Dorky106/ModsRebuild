using System.Collections.Generic;
using PhentrixGames.NewColonyAPI.Meshes;
using PhentrixGames.NewColonyAPI.Power;
using PhentrixGames.NewColonyAPI.Recipe;
using static PhentrixGames.NewColonyAPI.Power.PowerManager;

namespace PhentrixGames.NewColonyAPI.Content
{
    [NCAPIPowerType]
    public class SawmillBlock : Types.BaseType
    {
        public SawmillBlock() : base("Sawmill", true)
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

        public override List<BaseRecipe> AddRecipes()
        {
            List<BaseRecipe> recipes = new List<BaseRecipe>()
            {
                new BaseRecipe("sawmill.logtaiga.planks", "phentrixgames.sawmill", false)
                {
                    Requirements = new List<InventoryItem>()
                    {
                        new InventoryItem("logtaiga", 1)
                    },
                    Result = new List<InventoryItem>
                    {
                        new InventoryItem("planks", 6)
                    }
                },
                new BaseRecipe("sawmill.logtemperate.planks", "phentrixgames.sawmill", false)
                {
                    Requirements = new List<InventoryItem>()
                    {
                        new InventoryItem("logtemperate", 1)
                    },
                    Result = new List<InventoryItem>
                    {
                        new InventoryItem("planks", 6)
                    }
                }
            };

            return recipes;
        }
    }

    public class Sawmill : Machine
    {
        public Sawmill() : base("Sawmill", 200, 2)
        {
        }
    }
}