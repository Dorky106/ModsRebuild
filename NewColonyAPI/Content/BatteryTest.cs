using PhentrixGames.NewColonyAPI.Power;
using static PhentrixGames.NewColonyAPI.Power.PowerManager;

namespace PhentrixGames.NewColonyAPI.Content
{
    [NCAPIPowerType]
    public class BasicBatteryBlock : Types.BaseType
    {
        public BasicBatteryBlock() : base("Basic Battery", false)
        {
            this.IsPlaceable = true;
            PowerManager.ValidateBlockID(this.TypeName, new BasicBattery());
        }
    }

    public class BasicBattery : Power.Battery
    {
        public BasicBattery() : base("Basic Battery", 1000)
        {
        }
    }
}