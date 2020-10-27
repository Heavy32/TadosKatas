using System;
using System.Collections.Generic;
using System.Linq;

namespace FindTheDivisorsKata
{
	public class Kata
	{
		public static int[] Divisors(int number)
		{
			List<int> divisors = new List<int>();

			int limit = (int)Math.Sqrt(number);
			for (int i = 2; i <= limit; i++)
			{
				if (number % i == 0)
				{
					divisors.Add(i);
					if (i != number / i)
					{
						divisors.Add(number / i);
					}
				}
			}

			return divisors.Count != 0 ? divisors.OrderBy(x => x).ToArray() : null;
		}
	}
}
