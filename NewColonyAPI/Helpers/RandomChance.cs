using System;

namespace PhentrixGames.NewColonyAPI.Helpers
{
    public class RandomChance
    {
        private Random r = new Random();

        private int RandomRangeInt(int min, int max)
        {
            return r.Next(min, max);
        }

        public int WeightChance(int[] chances, int[] choices)
        {
            if (chances.Length != choices.Length)
            {
                Console.Write("ERROR: Choice Length != Chance Length");
                return 0;
            }
            int top = 0;
            int range = 0;
            for (var i = 0; i < chances.Length; i++) range += chances[i];
            var rand = RandomRangeInt(0, range);
            for (int i = 0; i < chances.Length; i++)
            {
                top += chances[i];
                if (rand < top)
                    return choices[i];
            }
            Console.Write("ERROR: Weighted Chance Logic Error");
            return 0;
        }
    }
}