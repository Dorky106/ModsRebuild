using PhentrixGames.NewColonyAPI.Power;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Power.PowerManager;

namespace PhentrixGames.RiseoftheNewColonies.PowerSystem.Batteries
{
    [NCAPIPowerType]
    public class BasicBatteryBlock : BaseType
    {
        public BasicBatteryBlock() : base("Basic Battery", false)
        {
            this.IsPlaceable = true;
            PowerManager.ValidateBlockID(this.TypeName, new BasicBattery());
        }
    }

    public class BasicBattery : Battery
    {
        public BasicBattery() : base("Basic Battery", 1000)
        {
        }
    }
}