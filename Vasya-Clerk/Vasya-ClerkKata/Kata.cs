using System.Collections.Generic;

namespace Vasya_ClerkKata
{
    public class Kata
    {
        public static string Tickets(int[] peopleInLine)
        {
            Dictionary<int, int> bills = new Dictionary<int, int>
            {
                { 25, 0 },
                { 50, 0 },
                { 100, 0 },
            };

            foreach (var item in peopleInLine)
            {
                if (item == 25)
                {
                    bills[25] += 1;
                }
                else if (item == 50)
                {
                    if (bills[25] > 0)
                    {
                        bills[50] += 1;
                        bills[25] -= 1;
                    }
                    else
                    {
                        return "NO";
                    }
                }
                else if (item == 100)
                {
                    if (bills[25] >= 1 && bills[50] >= 1)
                    {
                        bills[50] -= 1;
                        bills[25] -= 1;
                        bills[100] += 1;
                    }
                    else if (bills[25] >= 3)
                    {
                        bills[25] -= 3;
                        bills[100] += 1;
                    }
                    else
                    {
                        return "NO";
                    }
                }
            }

            return "YES";
        }
    }
}
