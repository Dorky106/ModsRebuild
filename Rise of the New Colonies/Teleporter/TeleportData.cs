using Pipliz;

namespace PhentrixGames.RiseoftheNewColonies.Teleporter
{
    public enum Availability
    {
        publ,
        priv,
        spawn
    }

    internal class TeleporterData
    {
        public Vector3Int location;
        public string teleportcode;
        public Availability availabile;

        public TeleporterData(Vector3Int pos, string key, Availability ava = Availability.priv)
        {
            location = pos;
            teleportcode = key;
            availabile = ava;
        }
    }
}