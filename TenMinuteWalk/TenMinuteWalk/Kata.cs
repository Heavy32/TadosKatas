using System.Collections.Generic;

namespace TenMinuteWalk
{
    public class Kata
    {
        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length != 10)
                return false;

            Dictionary<string, (int X, int Y)> directions = new Dictionary<string, (int X, int Y)>
            {
                { "n", (0, 1) },
                { "s", (0, -1) },
                { "w", (1, 0) },
                { "e", (-1, 0) }
            };

            (int X, int Y) resultPosition = (0, 0);

            foreach (var item in walk)
            {
                directions.TryGetValue(item, out (int X, int Y) direction);
                resultPosition = (resultPosition.X + direction.X, resultPosition.Y + direction.Y);
            }

            return resultPosition == (0, 0);
        }
    }
}
