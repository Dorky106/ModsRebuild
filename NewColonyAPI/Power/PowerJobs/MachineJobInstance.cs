using Jobs;
using Pipliz;

namespace PhentrixGames.NewColonyAPI.Power.PowerJobs
{
    public class MachineJobInstance : BlockJobInstance
    {
        public Recipes.Recipe SelectedRecipe
        {
            get;
            set;
        }

        public int SelectedRecipeCount
        {
            get;
            set;
        }

        public bool IsCrafting
        {
            get;
            set;
        }

        public MachineJobInstance(IBlockJobSettings settings, Vector3Int position, ItemTypes.ItemType type, ByteReader reader) : base(settings, position, type, reader)
        {
        }

        public MachineJobInstance(IBlockJobSettings settings, Vector3Int position, ItemTypes.ItemType type, Colony colony) : base(settings, position, type, colony)
        {
        }
    }
}