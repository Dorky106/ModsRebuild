namespace PhentrixGames.NewColonyAPI.Power
{
    public class PowerObject
    {
        public string Name
        {
            get;
            private set;
        }

        protected int Power;
        protected int MaxPower;

        public PowerObject(string name, int power, int maxPower)
        {
            Name = name;
            Power = power;
            MaxPower = maxPower;
        }

        public int GetPower()
        {
            return Power;
        }

        public int GetMaxPower()
        {
            return MaxPower;
        }
    }
}