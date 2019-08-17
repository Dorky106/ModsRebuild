using Jobs;
using Pipliz;

namespace PhentrixGames.NewColonyAPI.Power.PowerJobs
{
    public class GeneratorJobInstance : BlockJobInstance
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

        public GeneratorJobInstance(IBlockJobSettings settings, Vector3Int position, ItemTypes.ItemType type, ByteReader reader) : base(settings, position, type, reader)
        {
        }

        public GeneratorJobInstance(IBlockJobSettings settings, Vector3Int position, ItemTypes.ItemType type, Colony colony) : base(settings, position, type, colony)
        {
        }
    }
}