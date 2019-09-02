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
    public class AdvancedBatteryRecipe : BaseRecipe
    {
        public AdvancedBatteryRecipe() : base("AdvancedBatteryRecipe")
        {
            this.Requirements = new List<InventoryItem>
            {
                new InventoryItem("copper", 100),
                new InventoryItem("Basic Battery", 5)
            };

            this.Result = new List<InventoryItem>
            {
                new InventoryItem("Advanced Battery")
            };
        }
    }

    [NCAPIPowerType]
    public class AdvancedBatteryBlock : BaseType
    {
        public AdvancedBatteryBlock() : base("Advanced Battery", false)
        {
            this.IsPlaceable = true;
            if (MeshManager.GetMesh(Entry.ModName, "battery2", out string mesh))
            {
                this.Mesh = mesh;
            }
            this.Icon = Utilities.MultiCombine(Entry.ModIconDirectory, "battery2.png");
            PowerManager.ValidateBlockID(this.TypeName, new AdvancedBattery());
        }
    }

    public class AdvancedBattery : Battery
    {
        public AdvancedBattery() : base("Advanced Battery", 10000)
        { }
    }
}