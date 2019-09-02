using Jobs;
using System.Collections.Generic;

namespace PhentrixGames.NewColonyAPI.ColonyWandUI
{
    public class ColonyJobData
    {
        public int Avaible { get; set; } = 0;
        public int Taken { get; set; } = 0;
        public List<IJob> AvaibleJobs { get; set; } = new List<IJob>();
        public List<IJob> TakenJobs { get; set; } = new List<IJob>();
    }
}