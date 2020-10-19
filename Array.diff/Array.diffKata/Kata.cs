using System;
using System.Linq;

namespace Array.diffKata
{
    public class Kata
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            return a.Where(x => !b.Contains(x)).ToArray();
        }
    }
}
