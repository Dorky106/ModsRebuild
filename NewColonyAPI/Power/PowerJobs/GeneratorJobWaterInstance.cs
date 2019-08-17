using Jobs;
using Pipliz;

namespace PhentrixGames.NewColonyAPI.Power.PowerJobs
{
    public class GeneratorJobWaterInstance : GeneratorJobInstance
    {
        public Vector3Int WaterPoisiton
        {
            get;
            set;
        } = Vector3Int.invalidPos;

        public int counter = 0;

        public GeneratorJobWaterInstance(IBlockJobSettings settings, Vector3Int position, ItemTypes.ItemType type, ByteReader reader) : base(settings, position, type, reader)
        {
        }

        public GeneratorJobWaterInstance(IBlockJobSettings settings, Vector3Int position, ItemTypes.ItemType type, Colony colony) : base(settings, position, type, colony)
        {
        }
    }
}