using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Meshes;
using PhentrixGames.NewColonyAPI.Power;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using System.Collections.Generic;
using static PhentrixGames.NewColonyAPI.Power.PowerManager;

namespace PhentrixGames.RiseoftheNewColonies.PowerSystem.Batteries
{
    [NCAPIPowerRecipe]
    public class FusionBatteryRecipe : BaseRecipe
    {
        public FusionBatteryRecipe() : base("FusionBatteryRecipe")
        {
            this.Requirements = new List<InventoryItem>
            {
                new InventoryItem("copper", 500),
                new InventoryItem("Advanced Battery", 8)
            };

            this.Result = new List<InventoryItem>
            {
                new InventoryItem("Fusion Battery")
            };
        }
    }

    [NCAPIPowerType]
    public class FusionBatteryBlock : BaseType
    {
        public FusionBatteryBlock() : base("Fusion Battery", false)
        {
            this.IsPlaceable = true;
            if (MeshManager.GetMesh(Entry.ModName, "battery3", out string mesh))
            {
                this.Mesh = mesh;
            }
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "battery3.png");
            PowerManager.ValidateBlockID(this.TypeName, new FusionBattery());
        }
    }

    public class FusionBattery : Battery
    {
        public FusionBattery() : base("Fusion Battery", 100000)
        { }
    }
}