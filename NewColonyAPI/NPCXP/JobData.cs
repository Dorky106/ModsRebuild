namespace PhentrixGames.NewColonyAPI.NPCXP
{
    public class JobData
    {
        public string jobtype;
        public float cooldown;

        public JobData(string type, float cd)
        {
            jobtype = type;
            cooldown = cd;
        }
    }
}