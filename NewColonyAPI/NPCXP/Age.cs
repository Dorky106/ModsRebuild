namespace PhentrixGames.NewColonyAPI.NPCXP
{
    public class Age
    {
        public ushort Months
        {
            get;
            private set;
        }

        public ushort Years
        {
            get;
            private set;
        }

        public Age()
        {
            Months = 0;
            Years = 0;
        }

        public Age(ushort y, ushort m)
        {
            Months = m;
            Years = y;
        }

        internal void Increase()
        {
            Months++;
            if (Months >= 12)
            {
                Months = 0;
                Years++;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} years, {1} months", Years, Months);
        }
    }
}