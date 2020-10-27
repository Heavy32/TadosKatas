using System.Collections.Generic;

namespace ValidBracesKata
{
    public class Kata
    {
        public static bool ValidBraces(string input)
        {
            Stack<char> stack = new Stack<char>();

            Dictionary<char, char> pairs = new Dictionary<char, char>
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' }
            };

            foreach (var item in input)
            {
                if (pairs.ContainsKey(item))
                {
                    stack.Push(item);
                }
                else if (pairs.ContainsValue(item))
                {
                    if (stack.Count == 0 || pairs[stack.Pop()] != item)
                        return false;
                }
                else return false;
            }

            return stack.Count == 0;
        }

    }
}
