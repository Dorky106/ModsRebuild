using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhentrixGames.NewColonyAPI.Fluids
{
    public struct FluidInfo
    {
        public ushort source;
        public ushort fake;
        public ushort bucket;

        public int distance;
        public long time;

        public FluidInfo(ushort source, ushort fake, ushort bucket, int distance, long time)
        {
            this.bucket = bucket;
            this.source = source;
            this.fake = fake;
            this.distance = distance;
            this.time = time;
        }
    }
}