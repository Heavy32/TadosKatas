using System.Collections.Generic;

namespace ValidParenthesesKata
{
    public class Kata
    {
        public static bool ValidParentheses(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (var item in input)
            {
                switch (item)
                {
                    case '(':
                        stack.Push(item);
                        break;

                    case ')':
                        if (stack.Count == 0)
                            return false;
                        if (stack.Pop() != '(')
                            return false;
                        break;
                }
            }

            return stack.Count == 0;
        }
    }
}
