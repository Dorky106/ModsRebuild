using Pipliz;
using System.Collections.Generic;

namespace PhentrixGames.NewColonyAPI.Types
{
    public class ColliderData
    {
        public List<BoundsPip> bounds = new List<BoundsPip>();
        public bool collidePlayer = true;

        public ColliderData()
        { }
    }
}