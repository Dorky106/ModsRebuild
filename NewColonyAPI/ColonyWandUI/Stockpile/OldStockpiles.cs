namespace PhentrixGames.NewColonyAPI.ColonyWandUI.Stockpile
{
    internal class OldStockpiles
    {
        public Pipliz.Collections.SortedList<ushort, int> today = new Pipliz.Collections.SortedList<ushort, int>(0);
        public Pipliz.Collections.SortedList<ushort, int> yesterday = new Pipliz.Collections.SortedList<ushort, int>(0);
        public Pipliz.Collections.SortedList<ushort, int> twodaysago = new Pipliz.Collections.SortedList<ushort, int>(0);

        public Pipliz.Collections.SortedList<ushort, int> GetToday()
        {
            return today;
        }

        public Pipliz.Collections.SortedList<ushort, int> GetYesterday()
        {
            return yesterday;
        }

        public Pipliz.Collections.SortedList<ushort, int> GetTwodaysago()
        {
            return twodaysago;
        }

        public void NewDay()
        {
            yesterday.CopyTo(twodaysago);
            today.CopyTo(yesterday);
            today = new Pipliz.Collections.SortedList<ushort, int>(0);
        }
    }
}