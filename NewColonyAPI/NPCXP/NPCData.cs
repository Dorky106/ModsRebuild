namespace PhentrixGames.NewColonyAPI.NPCXP
{
    public class NPCData
    {
        public XPData XPData
        {
            get;
            private set;
        }

        public Colony Owner
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            internal set;
        }

        public Age Age
        {
            get;
            private set;
        }

        public NPCData(Colony o)
        {
            Owner = o;
            Name = NPCManager.GetRandomName();
            XPData = new XPData();
            Age = new Age();
        }

        public NPCData(Colony o, string age)
        {
            Owner = o;
            Name = NPCManager.GetRandomName();
            XPData = new XPData();

            string[] time = age.Split('.');
            this.Age = new Age(ushort.Parse(time[0]), ushort.Parse(time[1]));
        }

        internal void NPCAgeUp()
        {
            Age.Increase();
        }
    }
}