using System;

namespace SumStringsAsNumbersKata
{
    public class Kata
    {
        public static string SumStrings(string a, string b)
        {
            string output = "";
            int cache = 0;

            string big = a.Length > b.Length ? a : b;
            string small = a.Length > b.Length ? b : a;

            for (int i = big.Length - 1; i >= 0; i--)
            {
                int digit1 = (int)char.GetNumericValue(big[i]);
                int digit2 =
                    i - (big.Length - small.Length) >= 0
                    ? (int)char.GetNumericValue(small[i - (big.Length - small.Length)])
                    : 0;

                int tempSum = digit1 + digit2 + cache;

                int DigitThisIteration =
                    (i == 0)
                    ? tempSum
                    : tempSum % 10;

                cache = tempSum / 10;
                output = DigitThisIteration.ToString() + output;
            }

            return output.TrimStart('0');
        }
    }
}
