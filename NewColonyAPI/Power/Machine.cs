namespace PhentrixGames.NewColonyAPI.Power
{
    public class Machine : PowerObject
    {
        public int PowerUsage
        {
            get;
            private set;
        }

        public Machine(string name, int maxPower, int usage) : base(name, 0, maxPower)
        {
            PowerUsage = usage;
        }

        internal Machine(string name, int power, int maxPower, int usage) : base(name, power, maxPower)
        {
            PowerUsage = usage;
        }

        public bool Operate()
        {
            if (Power >= PowerUsage)
            {
                Power -= PowerUsage;
                return true;
            }
            return false;
        }

        public void RecievePower(int amt)
        {
            Power += amt;
            if (Power > MaxPower)
            {
                Power = MaxPower;
            }
        }

        public int PowerNeeded()
        {
            return (MaxPower - Power);
        }
    }
}