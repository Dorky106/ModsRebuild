using PhentrixGames.NewColonyAPI.Power;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using System.Collections.Generic;
using static PhentrixGames.NewColonyAPI.Power.PowerManager;

namespace PhentrixGames.RiseoftheNewColonies.PowerSystem.Machines
{
    [NCAPIPowerRecipe]
    public class ElectricForgeRecipe : BaseRecipe
    {
        public ElectricForgeRecipe() : base("ElectricForgeRecipe")
        {
            this.Requirements = new List<InventoryItem>
            {
                new InventoryItem("copper", 50),
                new InventoryItem("ironingot", 10)
            };

            this.Result = new List<InventoryItem>
            {
                new InventoryItem("Electric Forge")
            };
        }
    }

    [NCAPIPowerType]
    public class ElectricForgeBlock : BaseType
    {
        public ElectricForgeBlock() : base("Electric Forge", false)
        {
            this.IsPlaceable = true;
            PowerManager.ValidateBlockID(this.TypeName, new ElectricForge());
        }
    }

    public class ElectricForge : Machine
    {
        public ElectricForge() : base("Electric Forge", 200, 20)
        { }
    }
}