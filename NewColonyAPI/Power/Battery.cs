using System;

namespace PhentrixGames.NewColonyAPI.Power
{
    public class Battery : PowerObject
    {
        public Battery(string name, int maxPower) : base(name, 0, maxPower)
        { }

        internal Battery(string name, int power, int maxPower) : base(name, power, maxPower)
        { }

        public int HasPower(int needed)
        {
            int send = Math.Min(Power, needed);
            Power = (Power - send);
            return send;
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

        internal void PowerLose(int lose)
        {
            Power -= Math.Min(Power, lose);
        }
    }
}