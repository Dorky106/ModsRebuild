using PhentrixGames.NewColonyAPI.Meshes;
using PhentrixGames.NewColonyAPI.Power;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using System.Collections.Generic;
using static PhentrixGames.NewColonyAPI.Power.PowerManager;

namespace PhentrixGames.RiseoftheNewColonies.PowerSystem.Machines
{
    [NCAPIPowerRecipe]
    public class StoneCrusherRecipe : BaseRecipe
    {
        public StoneCrusherRecipe() : base("stonecrusherrecipe")
        {
            this.Requirements = new List<InventoryItem>
            {
                new InventoryItem("ironingot", 100)
            };

            this.Result = new List<InventoryItem>
            {
                new InventoryItem("Stone Crusher")
            };
        }
    }

    [NCAPIPowerType]
    public class StoneCrusherBlock : BaseType
    {
        public StoneCrusherBlock() : base("Stone Crusher", false)
        {
            this.IsPlaceable = true;
            this.Icon = NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModIconDirectory, "crusher.png");

            if (MeshManager.GetMesh(Entry.ModName, "crusher", out string mesh))
            {
                this.Mesh = mesh;
            }
            PowerManager.ValidateBlockID(this.TypeName, new StoneCrusher());
        }
    }

    public class StoneCrusher : Machine
    {
        public StoneCrusher() : base("Stone Crusher", 200, 10)
        {
        }
    }
}