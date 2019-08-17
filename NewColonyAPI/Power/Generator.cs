using System;

namespace PhentrixGames.NewColonyAPI.Power
{
    public class Generator : PowerObject
    {
        public int Generates
        {
            get;
            private set;
        }

        public Generator(string name, int maxPower, int generates) : base(name, 0, maxPower)
        {
            Generates = generates;
        }

        internal Generator(string name, int power, int maxPower, int generates) : base(name, power, maxPower)
        {
            Generates = generates;
        }

        public void Generate()
        {
            Power += Generates;
            if (Power > MaxPower)
            {
                Power = MaxPower;
            }
        }

        public int HasPower(int needed)
        {
            int send = Math.Min(Power, needed);
            Power = Power - send;
            return send;
        }
    }
}