using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Power.PowerManager;

namespace PhentrixGames.RiseoftheNewColonies.Teleporter
{
    [NCAPIPowerType]
    public class RecallDevice : BaseType
    {
        public RecallDevice() : base("Recall Device", false)
        {
            this.IsPlaceable = false;
        }
    }
}