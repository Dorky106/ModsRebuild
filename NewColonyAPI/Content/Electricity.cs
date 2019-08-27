namespace PhentrixGames.NewColonyAPI.Content
{
    [Power.PowerManager.NCAPIPowerType]
    public class Electricity : Types.BaseType
    {
        public Electricity() : base("electricity", false)
        {
            this.Icon = NewColonyAPIEntry.ModIconDirectory + "/electricity.png";
        }
    }
}